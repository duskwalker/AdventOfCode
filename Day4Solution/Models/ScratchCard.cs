namespace Day4Solution.Models
{
    public class ScratchCard
    {
        public string CardId { get; private  set; }
        public List<int> WinningNumbers { get; private set; }
        public List<int> YourNumbers { get; private set; }

        public ScratchCard(string cardId, List<int> winningNumbers, List<int> yourNumbers)
        {
            CardId = cardId;
            WinningNumbers = winningNumbers;
            YourNumbers = yourNumbers;
        }
    }
}
