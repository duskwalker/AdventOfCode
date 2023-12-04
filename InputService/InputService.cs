namespace InputService
{
    public class FileInputService
    : IInputService
    {
        private readonly string _filePath;

        public FileInputService(string filePath)
        {
            _filePath = filePath;
        }
        
        public IEnumerable<string> Read()
        {
            return File.ReadAllLines(_filePath);
        }
    }
}
