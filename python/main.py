from time import time
from json import load, dumps

start = time()
with open('messages.json', encoding='utf-8') as file:
    messages = load(file)['messages']
messages.reverse()
temp_msgs = {msg['id']: msg['content'] for msg in messages}
answers = {}

for message in messages:
    if message['reply_message_id'] is not None:
        text = temp_msgs.get(message['reply_message_id'])
        if text is None:
            continue
        if answers.get(text) is not None:
            answers[text].append(message['content'])
            continue
        answers[text] = [message['content']]

with open('answers.json', 'w', encoding='utf-8') as file:
    file.write(dumps({'answers': answers}, ensure_ascii=False))

print(round(time() - start, 4))
