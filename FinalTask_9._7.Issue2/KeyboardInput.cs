namespace FinalTask_9._7.Issue2;

internal class KeyboardInput
{
    public event Program.EventHandler? InputEvent;

    /// <summary>
    /// Запрашивает ввод пользователя для выбора действия и вызывает соответствующее событие.
    /// </summary>
    public void InputSelect()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nВведите 1 для сортировки А-Я, 2 для сортировки Я-А, или 'q' для выхода:");

            try
            {
                var input = Console.ReadKey(true).KeyChar;
                string? action;

                switch (input)
                {
                    case '1':
                        action = "Сортировка А-Я";
                        break;

                    case '2':
                        action = "Сортировка Я-А";
                        break;

                    case 'q':
                        action = "Выход";
                        break;

                    default:
                        throw new InvalidUserInputException($"Неверный выбор: '{input}'");
                }

                InputEvent?.Invoke(this, action);
                break;
            }
            catch (InvalidUserInputException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Program.PressAnyKey();
                InputEvent?.Invoke(this, Convert.ToString(ex));

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                Program.PressAnyKey();
                InputEvent?.Invoke(this, ex.Message);
            }
        }
    }
}