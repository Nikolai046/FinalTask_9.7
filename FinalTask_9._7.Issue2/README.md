# Программа для сортировки списка фамилий

Это консольное приложение на C# для сортировки списка фамилий.

## Возможности

- Отображение текущего списка фамилий
- Сортировка списка от А до Я
- Сортировка списка от Я до А
- Логирование действий пользователя
- Возможность выхода из программы

## Структура проекта

Проект состоит из следующих основных классов:

- `Program`: Основной класс, управляющий логикой приложения
- `Person`: Класс для представления человека (содержит фамилию)
- `KeyboardInput`: Класс для обработки пользовательского ввода
- `EventLogger`: Класс для логирования событий

## Как использовать

1. Запустите приложение
2. Используйте клавиши для выбора действия:
   - `1`: Сортировка от А до Я
   - `2`: Сортировка от Я до А
   - `q`: Выход из программы
3. После каждого действия список фамилий будет отображаться на экране

## Логирование

Все действия пользователя логируются в файл `events.log` в формате:
YYYY-MM-DD HH:mm:ss.fff -- инициатор:[ИмяКласса] -- событие:[Действие]

## Требования

- .NET 6.0 или выше