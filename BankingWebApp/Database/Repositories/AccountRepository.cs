using BankingWebApp.Base;

namespace BankingWebApp.Database.Repositories
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository(BankAppDbContext context) : base(context)
        {
        }

        public IEnumerable<Account> GetAccountsWithCustomersAndTransactions()
        {
            var accounts = GetTable().Include(a => a.DebitTransactions).Include(a => a.Customer);
            return accounts;
        }
    }
}
