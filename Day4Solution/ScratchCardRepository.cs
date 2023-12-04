using Common;
using Day4Solution.Models;
using InputService;
using OutputService;

namespace Day4Solution
{
    internal class ScratchCardRepository
        : RepositoryBase<ScratchCard>
    {
       public ScratchCardRepository(IInputService inputService, IAdapter<ScratchCard> adapter) 
           : base(inputService, adapter) { }
    }
}
