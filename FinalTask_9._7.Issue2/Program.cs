namespace FinalTask_9._7.Issue2;

internal class Program
{
    public delegate void EventHandler(object sender, string? action);

    private static readonly List<Person> People = new()
    {
        new Person("Иванов"),
        new Person("Петров"),
        new Person("Сидоров"),
        new Person("Александров"),
        new Person("Михайлов")
    };

    private static void Main()
    {
        EventLogger eventLogger = new(null, "Программа запущена");
        PrintPeople();
        while (true)
        {
            KeyboardInput keyboardInput = new();
            keyboardInput.InputEvent += SortSurnames;
            keyboardInput.InputEvent += LogEvent;
            keyboardInput.InputEvent += ExitProgram;
            keyboardInput.InputSelect();
            PrintPeople();
        }
    }

    /// <summary>
    /// Выводит на экран текущий список фамилий.
    /// </summary>
    private static void PrintPeople()
    {
        Console.Clear();
        Console.WriteLine("Текущий список фамилий:\n");
        People.ForEach(person => Console.WriteLine(person.Surname));
        PressAnyKey();
    }

    /// <summary>
    /// Сортирует список фамилий в зависимости от выбранного действия.
    /// </summary>
    private static void SortSurnames(object sender, string action)
    {
        switch (action)
        {
            case "Сортировка А-Я":
                People.Sort((person1, person2) =>
                    string.Compare(person1.Surname, person2.Surname, StringComparison.Ordinal));
                break;

            case "Сортировка Я-А":
                People.Sort((person1, person2) =>
                    string.Compare(person2.Surname, person1.Surname, StringComparison.Ordinal));
                break;
        }
    }

    /// <summary>
    /// Создает новую запись в логе о произошедшем событии.
    /// </summary>
    private static void LogEvent(object? sender, string action)
    {
        EventLogger eventLogger = new(sender, action);
    }

    /// <summary>
    /// Ожидает нажатия любой клавиши пользователем.
    /// </summary>
    public static void PressAnyKey()
    {
        Console.SetCursorPosition(0, Console.WindowHeight - 3);
        Console.Write("Нажмите любую кнопку...");
        Console.ReadKey();
        Console.Clear();
    }

    /// <summary>
    /// Завершает выполнение программы, если выбрано соответствующее действие.
    /// </summary>
    private static void ExitProgram(object sender, string action)
    {
        if (action != "Выход") return;
        Console.Clear();
        Console.WriteLine("Программа завершает работу. До свидания!");
        Environment.Exit(0);
    }
}