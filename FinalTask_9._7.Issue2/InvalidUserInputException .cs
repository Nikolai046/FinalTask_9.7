namespace FinalTask_9._7.Issue2
{
    public class InvalidUserInputException : Exception
    {
        public InvalidUserInputException() : base("Введено недопустимое значение.") { }
        public InvalidUserInputException(string? message) : base(message) { }
        public InvalidUserInputException(string message, Exception inner) : base(message, inner) { }
    }
}
