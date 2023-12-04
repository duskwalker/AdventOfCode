namespace OutputService
{
    public interface IAdapter<out T>
    {
        T Adapt(string input);
    }
}
