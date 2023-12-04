using Day4Solution.Models;
using OutputService;

namespace Day4Solution
{
    internal class ScratchCardAdapter
    : IAdapter<ScratchCard>
    {
        public ScratchCard Adapt(string input)
        {
            var parts = input.Split(':', '|');
            var cardId = parts[0];
            var winningNumbers = parts[1].Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var yourNumbers = parts[2].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

             return new ScratchCard(cardId, winningNumbers, yourNumbers);
        }
    }
}
