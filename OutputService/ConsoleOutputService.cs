namespace OutputService
{
    public class ConsoleOutputService
    : IOutputService
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
