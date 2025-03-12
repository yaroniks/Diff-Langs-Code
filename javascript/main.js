const fs = require("fs");

console.time("Execution Time");
const data = fs.readFileSync("messages.json", "utf8");
const messages = JSON.parse(data).messages;
messages.reverse();
let temp_msgs = {};
messages.forEach(message => {temp_msgs[message.id] = message.content});
let answers = {};

messages.forEach(message => {
    if(message.reply_message_id != null) {
        const text = temp_msgs[message.reply_message_id];
        if (text == undefined) return;
        if (answers[text] != undefined) {
            answers[text].push(message.content);
        } else {
            answers[text] = [message.content];
        }
    } 
})

fs.writeFileSync("answers.json", JSON.stringify(answers), "utf8");
console.timeEnd("Execution Time"); 
