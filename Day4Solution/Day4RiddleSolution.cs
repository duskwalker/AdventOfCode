using Common;
using Day4Solution.Models;
using InputService;
using OutputService;

namespace Day4Solution
{
    public class Day4RiddleSolution
        : IRiddleSolution    
    {
        private readonly IOutputService _outputService;
        private readonly IRepository<ScratchCard> _scratchCardRepository;

        public Day4RiddleSolution()
        {
            _outputService = new ConsoleOutputService();
            _scratchCardRepository = new ScratchCardRepository(new FileInputService(@"./Assets/day4input.txt"), new ScratchCardAdapter());
        }

        public void Solve()
        {
            int sum = _scratchCardRepository.GetAll().Sum(EvaluateCard);

            _outputService.Write($"Total wins : {sum}");
        }

        private int EvaluateCard(ScratchCard scratchCard)
        {
            int length = scratchCard.WinningNumbers.Intersect(scratchCard.YourNumbers).Count();

            return length > 1 ? 1 << (length - 1) : length; 
        }

    }
}
