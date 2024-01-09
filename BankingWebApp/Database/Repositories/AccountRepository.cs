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
            var accounts = GetTable()!
            .Include(a => a.DebitTransactions)!
            .ThenInclude(t => t.Sender)!
            .ThenInclude(a => a!.Customer)!
            .Include(a => a.CreditTransactions)!
            .ThenInclude(t => t.Receiver)
            .ThenInclude(a => a!.Customer)
            .Include(a => a.Customer);

            return accounts;
        }
    }
}
