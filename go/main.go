package main

import (
	"encoding/json"
	"fmt"
	"os"
	"slices"
	"time"
)

type Message struct {
	Id               int    `json:"id"`
	Content          string `json:"content"`
	Reply_message_id *int   `json:"reply_message_id"`
}

type Messages struct {
	Messages []Message `json:"messages"`
}

func main() {
	start := time.Now()
	file, err := os.ReadFile("messages.json")
	if err != nil {
		panic(err)
	}
	var data Messages
	if err := json.Unmarshal(file, &data); err != nil {
		panic(err)
	}
	messages := data.Messages
	slices.Reverse(messages)
	temp_msgs := make(map[int]string)
	for _, msg := range messages {
		temp_msgs[msg.Id] = msg.Content
	}
	answers := make(map[string][]string)

	for _, message := range messages {
		if message.Reply_message_id != nil {
			text, ok := temp_msgs[*message.Reply_message_id]
			if ok {
				answer, ok := answers[text]
				if ok {
					answers[text] = append(answer, message.Content)
				} else {
					answers[text] = []string{message.Content}
				}
			}
		}
	}

	to_json := map[string]map[string][]string{"answers": answers}
	to_file, err := json.Marshal(to_json)
	if err != nil {
		panic(err)
	}
	if err := os.WriteFile("answers.json", to_file, 0644); err != nil {
		panic(err)
	}

	fmt.Println(time.Since(start).Seconds())
}
