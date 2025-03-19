using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

class Program {
    static void Main() {
        var start = Stopwatch.StartNew();
        string data = File.ReadAllText("messages.json");
        using JsonDocument doc = JsonDocument.Parse(data);
        JsonElement root = doc.RootElement;
        JsonElement messagesArray = root.GetProperty("messages");
        var messages = new List<JsonElement>();
        foreach (JsonElement element in messagesArray.EnumerateArray()) {
            messages.Add(element);
        }
        messages.Reverse();
        var temp_msgs = new Dictionary<long, string>();
        foreach (var message in messages) {
            long id = message.GetProperty("id").GetInt64();
            string content = message.GetProperty("content").GetString();
            temp_msgs[id] = content;
        }
        var answers = new Dictionary<string, List<string>>();

        foreach (var message in messages) {
            if (message.TryGetProperty("reply_message_id", out JsonElement replyIdElement) && replyIdElement.ValueKind != JsonValueKind.Null) {
                long replyId = replyIdElement.GetInt64();
                if (temp_msgs.TryGetValue(replyId, out string text)) {
                    if (!answers.ContainsKey(text))
                        answers[text] = new List<string>();
                    answers[text].Add(message.GetProperty("content").GetString());
                }
            }
        }

        string outputJson = JsonSerializer.Serialize(new { answers }, new JsonSerializerOptions { WriteIndented = false, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        File.WriteAllText("answers.json", outputJson);
        
        start.Stop();
        Console.WriteLine(start.Elapsed.TotalSeconds);
    }
}
