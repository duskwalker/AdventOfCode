using InputService;
using OutputService;

namespace Common
{
    public class RepositoryBase<T>
    : IRepository<T>
    {
        private readonly IInputService _inputService;
        private readonly IAdapter<T> _adapter;

        public RepositoryBase(IInputService inputService, IAdapter<T> adapter)
        {
            _inputService = inputService;
            _adapter = adapter;
        }
        public IEnumerable<T> GetAll()
        {
            var lines = _inputService.Read();
            return lines.Select(_adapter.Adapt);
        }
    }
}
