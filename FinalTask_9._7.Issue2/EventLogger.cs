namespace FinalTask_9._7.Issue2;

internal class EventLogger
{
    private string EventTime { get; }
    private string? Sender { get; }
    private string TypeOfEvent { get; }
    public EventLogger(object? sender, string eventType)
    {
        Sender = sender?.GetType().Name;
        TypeOfEvent = eventType;
        EventTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        SaveLogToFile();
    }

    /// <summary>
    /// Создает новую запись лога событий и сохраняет ее в файл.
    /// </summary>
    private void SaveLogToFile()
    {
        try
        {
            using (var sw = File.AppendText("events.log"))
            {
                sw.WriteLine($"{EventTime}\nинициатор: {Sender}\nсобытие: {TypeOfEvent}\n\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка записи файла events.log: {ex.Message}");
        }
    }
}