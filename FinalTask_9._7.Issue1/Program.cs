class Program
{
    // Создаем свой тип исключения
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    static void Main(string[] args)
    {
        // Создаем массив исключений
        Exception[] exceptions =
        {
            new CustomException("Cобственный тип исключения"),
            new ArgumentException("Неверный аргумент"),
            new DivideByZeroException("Попытка деления на ноль"),
            new IndexOutOfRangeException("Индекс вне диапазона"),
            new NullReferenceException("Обращение к null-ссылке")
        };

        foreach (var exception in exceptions)
        {
            try
            {
                Console.WriteLine($"Попытка вызвать исключение: {exception.GetType().Name}");
                throw exception;
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Поймано CustomException: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Поймано ArgumentException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Поймано DivideByZeroException: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Поймано IndexOutOfRangeException: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Поймано NullReferenceException: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Программа завершена");
    }
}