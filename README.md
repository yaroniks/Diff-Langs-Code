# Сравнение скорости разных языков
**Задача:** 
1. Написать код, который сортирует 1 119 697 сообщений из дискорд чата в формате: "сообщение": "ответы на него"
2. Сравнить скорость выполнения кода и количество строк на 7 языках: Python, Java, C#, C++, C, Go, JavaScript.

**Пример изначального файла (messages.json):**
```json
{
    "messages": [
        {"id": 1246207194978844794, "content": "дарова всем", "reply_message_id": null},
        {"id": 1246207755858083840, "content": "привет, друк", "reply_message_id": 1246207194978844794}, 
    ]
}
```

**Пример ожидаемого результата (answers.json):**
```json
{
    "answers": {
        "Привет": [
            "Ты кто?", "Привте", "Привет", "Привет!!!", "драсте", "Какие люди, здрасьте", "Как дела?", "Darova", "Привет пупсик", "Пока", "Гуттен так", "Мой любимчик", "Хай", "Здрасте", "ку"
        ],
    }
}
```

Начнём пожалуй с самого медленного...

---

### 5. 


Кол-во строк: **0**</br>
Максимальное: **0 сек.**</br>
Минимальное: **0 сек.**</br>
Среднее: **0 сек.**</br>
Код: [`./`]()

### 4. JavaScript
Высокоуровневый, динамическая типизация, не объектно-ориентированный.

Кол-во строк: **25**</br>
Максимальное: **2.667 сек.**</br>
Минимальное: **2.313 сек.**</br>
Среднее: **2.4645 сек.**</br>
Код: [`./javascript/main.js`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/javascript/main.js)

### 3. Python
Высокоуровневый, динамическая типизация, объектно-ориентированный.

Кол-во строк: **24**</br>
Максимальное: **2.1281 сек.**</br>
Минимальное: **1.9358 сек.**</br>
Среднее: **2.00823 сек.**</br>
Код: [`./python/main.py`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/python/main.py)

### 2. GO
Высокоуровневый, статическая типизация, не объектно-ориентированный.

Кол-во строк: **63**</br>
Максимальное: **1.7452 сек.**</br>
Минимальное: **1.5877 сек.**</br>
Среднее: **1.63226 сек.**</br>
Код: [`./go/main.go`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/go/main.go)

### 1. Java
Высокоуровневый, статическая типизация, объектно-ориентированный.

Кол-во строк: **40**</br>
Максимальное: **1.632 сек.**</br>
Минимальное: **1.454 сек.**</br>
Среднее: **1.5099 сек.**</br>
Код: [`./java/src/java/org/messages/Main.java`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/java/src/main/java/org/messages/Main.java)

---

### Итоги:
| Место | Язык       | Ср. время, сек. | Кол-во строк |
|:-----:|:-----------|:----------------|:-------------|
| 1     | Java       | 1.5099          | 43           |
| 2     | GO         | 1.63226         | 63           |
| 3     | Python     | 2.00823         | 24           |
| 4     | JavaScript | 2.4645          | 25           |
| 5     |            |                 |              |
| 6     |            |                 |              |
| 7     |            |                 |              |
