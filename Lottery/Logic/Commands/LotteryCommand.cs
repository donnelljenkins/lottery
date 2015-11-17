using Lottery.Domain;

namespace Lottery.Logic.Commands
{
    public abstract class LotteryCommand<TRequest, TResponse>
    {
        private readonly LotteryContext _context;
        protected LotteryContext Context;
        protected TRequest Request;

        public LotteryCommand(LotteryContext context = null)
        {
            _context = context;
        }

        public TResponse Execute(TRequest request)
        {
            using (var context = _context ?? new LotteryContext())
            {
                Context = context;
                Request = request;

                var response = DoExecute();

                Context.SaveChanges();

                return response;
            }
        }

        protected abstract TResponse DoExecute();
    }
}