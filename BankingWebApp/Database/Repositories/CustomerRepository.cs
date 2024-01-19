
using BankingWebApp.Base;

namespace BankingWebApp.Database.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {

        public CustomerRepository(BankAppDbContext context) : base(context)
        {
        }

        //used for login verification
        public Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            var cust = GetAll().FirstOrDefault(c => c.EmailAddress == email && c.Password == password);

            if (cust == null) throw new InvalidOperationException($"Customer with email: {email} or password: {password} not found in database");

            return cust;
        }

        public Customer GetCustomerByEmail(string email)
        {
            var cust = GetAll().FirstOrDefault(c => c.EmailAddress == email);

            //if (cust == null) throw new InvalidOperationException($"Customer with {nameof(cust.EmailAddress)}: {email} not found in database");

            return cust;
        }

        public IEnumerable<Customer> GetCustomersWithAccountsAndTransactions()
        {
            var customers = GetTable().Include(c => c.Accounts)!.ThenInclude(a => a.DebitTransactions).ToList();

            return customers;
        }
    }
}
