namespace Common
{
    public interface IRepository<out T>
    {
        IEnumerable<T> GetAll();
    }
}
