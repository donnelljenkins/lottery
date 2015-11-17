using System.Linq;
using Lottery.Domain;
using Lottery.Logic.Queries;

namespace Lottery.Logic.Commands
{
    public class IsWinningTicketCommand : LotteryCommand<Ticket, bool>
    {
        private readonly LotteryQuery<DrawnNumbers> _query;

        public IsWinningTicketCommand(LotteryQuery<DrawnNumbers> query = null)
        {
            _query = query ?? new LotteryQuery<DrawnNumbers>();
        }

        protected override bool DoExecute()
        {
            var drawnNumbers = _query.Include(x => x.Values).GetLast();

            return RequestMatches(drawnNumbers);
        }

        private bool RequestMatches(Numbers drawnNumbers)
        {
            return Request.Chances.Any(chance => ChanceMatches(chance, drawnNumbers));
        }

        private bool ChanceMatches(Chance chance, Numbers drawnNumbers)
        {
            var matchingValues = chance.Values.Intersect(drawnNumbers.Values);

            return matchingValues.Count() == drawnNumbers.Values.Count;
        }
    }
}