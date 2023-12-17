using BankingWebApp.Base;

namespace BankingWebApp.Database.Repositories
{
    public class TransactionRepository : BaseRepository<Transaction>
    {
        public TransactionRepository(BankAppDbContext context) : base(context)
        {
        }
    }
}
