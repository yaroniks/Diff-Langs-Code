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
            "Ты кто?", "Привте", "Привет", "привет", "Привет!!!", "драсте", "Джа!", "Какие люди, здрасьте", "Как дела?", "Darova", "Privet", "Здравствуйте, Богдан.", "Привет.", "Привет пупсик", "Пока", "привет.", "Как дела дядя гоинг?", "Пон", "Как поспал?", ":pleading_face:", "Привет:flushed:", "Привееееет", "Гуттен так", "Мой любимчик", ":face_with_raised_eyebrow:", "Хай", "Здрасте", "ку", "Ку", "Ты хто?", "Как дела, как жизнь?", "Дарова", "Прив"
        ],
    }
}
```

Начнём пожалуй с самого медленного...

---

### 7. 
Среднее время выполнения кода: ** сек.**</br>
Максимальное: ** сек.**</br>
Минимальное: ** сек.**</br>
Кол-во строк: ****</br>
Код: [`./`]()

### 6. 
Среднее время выполнения кода: ** сек.**</br>
Максимальное: ** сек.**</br>
Минимальное: ** сек.**</br>
Кол-во строк: ****</br>
Код: [`./`]()

### 5. 
Среднее время выполнения кода: ** сек.**</br>
Максимальное: ** сек.**</br>
Минимальное: ** сек.**</br>
Кол-во строк: ****</br>
Код: [`./`]()

### 4. 
Среднее время выполнения кода: ** сек.**</br>
Максимальное: ** сек.**</br>
Минимальное: ** сек.**</br>
Кол-во строк: ****</br>
Код: [`./`]()

### 3. JavaScript
Среднее время выполнения кода: **2.4645 сек.**</br>
Максимальное: **2.667 сек.**</br>
Минимальное: **2.354 сек.**</br>
Кол-во строк: **25**</br>
Код: [`./javascript/main.js`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/javascript/main.js)

### 2. Python
Среднее время выполнения кода: **2.00823 сек.**</br>
Максимальное: **2.1281 сек.**</br>
Минимальное: **1.9615 сек.**</br>
Кол-во строк: **25**</br>
Код: [`./python/main.py`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/python/main.py)

### 1. GO
Среднее время выполнения кода: **1.63226 сек.**</br>
Максимальное: **1.7452274 сек.**</br>
Минимальное: **1.5876503 сек.**</br>
Кол-во строк: **65**</br>
Код: [`./go/main.go`](https://github.com/yaroniks/Diff-Langs-Code/blob/main/go/main.go)

---

### Итог:
| Место | Язык       | Ср. время, сек. | Кол-во строк |
|:-----:|:-----------|:----------------|:-------------|
| 1     | GO         | 1.63226         | 65           |
| 2     | Python     | 2.00823         | 25           |
| 3     | JavaScript | 2.4645          | 25           |
| 4     |            |                 |              |
| 5     |            |                 |              |
| 6     |            |                 |              |
| 7     |            |                 |              |
