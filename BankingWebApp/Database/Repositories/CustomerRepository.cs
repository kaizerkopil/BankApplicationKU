
using BankingWebApp.Base;

namespace BankingWebApp.Database.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {

        public CustomerRepository(BankAppDbContext context) : base(context)
        {
        }

        public Customer GetCustomerByEmail(string email)
        {
            var cust = GetAll().FirstOrDefault(c => c.EmailAddress == email);

            if (cust == null) throw new InvalidOperationException($"Customer with email {email} not found in database");

            return cust;
        }

        public IEnumerable<Customer> GetCustomersWithAccountsAndTransactions()
        {
            var customers = GetTable().Include(c => c.Accounts)!.ThenInclude(a => a.DebitTransactions).ToList();

            return customers;
        }
    }
}
