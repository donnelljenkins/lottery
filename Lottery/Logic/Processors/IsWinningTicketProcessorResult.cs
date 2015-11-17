namespace Lottery.Logic.Processors
{
    public class IsWinningTicketProcessorResult
    {
        public bool IsWinner { get; }

        public IsWinningTicketProcessorResult(bool isWinner)
        {
            IsWinner = isWinner;
        }
    }
}