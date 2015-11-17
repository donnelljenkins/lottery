using Lottery.Domain;
using Lottery.Logic.Queries;

namespace Lottery.Logic.Commands
{
    public class GetDrawnNumbersCommand : LotteryCommand<object, DrawnNumbers>
    {
        private readonly LotteryQuery<DrawnNumbers> _query;

        public GetDrawnNumbersCommand(LotteryQuery<DrawnNumbers> query = null)
        {
            _query = query ?? new LotteryQuery<DrawnNumbers>();
        }

        protected override DrawnNumbers DoExecute()
        {
            return _query.Include(x => x.Values).GetLast();
        }
    }
}
