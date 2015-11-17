using System.Data.Entity;

namespace Lottery.Domain
{
    public class LotteryContext : DbContext
    {
        public DbSet<DrawnNumbers> DrawnNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrawnNumbers>().HasMany(e => e.Values);
        }
    }
}