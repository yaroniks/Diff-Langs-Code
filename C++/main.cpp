#include <iostream>
#include <fstream>
#include <unordered_map>
#include <vector>
#include "json.hpp"
#include <chrono>

using json = nlohmann::json;
using namespace std;
using namespace chrono;

int main() {
    auto start = high_resolution_clock::now();
    ifstream file("messages.json");
    json j;
    file >> j;
    file.close();
    const auto& messages = j["messages"];
    size_t messagesSize = messages.size();
    unordered_map<int, string> temp_msgs;
    temp_msgs.reserve(messagesSize);
    for (const auto& msg : messages) {
        int id = msg["id"].get<int>();
        temp_msgs.emplace(id, msg["content"].get<string>());
    }
    
    unordered_map<string, vector<string>> answers;
    for (const auto& msg : messages) {
        if (msg.contains("reply_message_id") && !msg["reply_message_id"].is_null()) {
            int reply_id = msg["reply_message_id"].get<int>();
            auto it = temp_msgs.find(reply_id);
            if (it != temp_msgs.end()) {
                answers[it->second].push_back(msg["content"].get<string>());
            }
        }
    }
    
    json output;
    output["answers"] = answers;
    ofstream out_file("answers.json");
    out_file << output.dump();
    out_file.close();
    
    auto end = high_resolution_clock::now();
    duration<double> elapsed = end - start;
    cout << elapsed.count() << endl;
    return 0;
}
