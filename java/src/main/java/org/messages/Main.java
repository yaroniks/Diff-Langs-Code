package org.messages;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.node.ObjectNode;
import java.io.File;
import java.io.IOException;
import java.nio.file.Paths;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {
        long start = System.currentTimeMillis();
        ObjectMapper mapper = new ObjectMapper();
        File inputFile = Paths.get("messages.json").toFile();
        JsonNode data = mapper.readTree(inputFile);
        List<JsonNode> messages = new ArrayList<>();
        data.get("messages").forEach(messages::add);
        Collections.reverse(messages);
        Map<Integer, String> temp_msgs = new HashMap<>();
        for (JsonNode message : messages) 
            temp_msgs.put(message.get("id").asInt(), message.get("content").asText());
        Map<String, List<String>> answers = new HashMap<>();

        for (JsonNode message : messages) {
            if (message.has("reply_message_id") && !message.get("reply_message_id").isNull()) {
                int replyId = message.get("reply_message_id").asInt();
                String text = temp_msgs.get(replyId);
                if (text != null) {
                    answers.computeIfAbsent(text, k -> new ArrayList<>()).add(message.get("content").asText());
                }
            }
        }

        ObjectNode outputNode = mapper.createObjectNode();
        outputNode.set("answers", mapper.valueToTree(answers));
        mapper.writerWithDefaultPrettyPrinter().writeValue(new File("answers.json"), outputNode);

        System.out.println((System.currentTimeMillis() - start) / 1000.0);
    }
}
