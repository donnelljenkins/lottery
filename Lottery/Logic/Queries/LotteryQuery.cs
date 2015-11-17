using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Lottery.Domain;

namespace Lottery.Logic.Queries
{
    public class LotteryQuery<TEntity>
        where TEntity : Entity
    {
        private readonly LotteryContext _context;
        private Expression<Func<TEntity, object>> _includeFunc;

        public LotteryQuery()
        {
            _context = new LotteryContext();
        }

        public TEntity GetLast()
        {
            IQueryable<TEntity> queryable = _context.Set<TEntity>();
            if (_includeFunc != null)
                queryable = queryable.Include(_includeFunc);

            queryable = queryable.OrderByDescending(x => x.Id);
            return queryable.FirstOrDefault();
        }

        public LotteryQuery<TEntity> Include(Expression<Func<TEntity, object>> func)
        {
            _includeFunc = func;
            return this;
        }
    }
}
