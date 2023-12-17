
using BankingWebApp.Base;

namespace BankingWebApp.Database.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {

        public CustomerRepository(BankAppDbContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetCustomersWithAccountsAndTransactions()
        {
            var customers = GetTable().Include(c => c.Accounts)!.ThenInclude(a => a.DebitTransactions).ToList();

            return customers;
        }
    }
}
