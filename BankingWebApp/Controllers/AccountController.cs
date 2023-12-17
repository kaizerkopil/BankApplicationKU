
using BankingWebApp.Base;
using Microsoft.AspNetCore.Mvc;

namespace BankingWebApp.Controllers;

public class AccountController : BaseController<AccountController>
{
    private AccountRepository _repo;

    public AccountController(ILogger<AccountController> logger, AccountRepository repo) : base(logger)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        _logger.LogCritical($"{this.GetType()} {nameof(Index)} page ran");
        _repo.Insert(new Account());
        var accounts = _repo.GetAll();
        return View();
    }



    #region Showcasing Insertion of Related Data (Data between relational tables)
    //public IActionResult UserAccountDisabled()
    //{
    //    var customerToRemove = _context.Find<Customer>(9);
    //    if (customerToRemove is not null)
    //    {
    //        _context.Remove<Customer>(customerToRemove);
    //        _context.SaveChanges();
    //    }

    //    //ThenInclude DebitTransactions makes such that it also ThenIncludes CreditTransactions
    //    //var customers = _context.Customers.Include(c => c.Accounts).ThenInclude(a => a.DebitTransactions).ToList();

    //    //Include CreditTransactions or DebitTransactions makes it such that it includes the other 
    //    //Include Customer makes it such it populates the Customer details
    //    var accounts = _context.Accounts.Include(a => a.Customer).Include(a => a.CreditTransactions).ToList();
    //    var transactions = _context.Transactions.ToList();

    //    var customer = new Customer("Narul", "Ahmed", "narum@gg.com", string.Empty, string.Empty, string.Empty, string.Empty);

    //    var doCustomerExist = _context.Customers.FirstOrDefault(c => c.EmailAddress == customer.EmailAddress);

    //    if (doCustomerExist is null)
    //    {
    //        _context.Add(customer);
    //        _context.SaveChanges();
    //    }

    //    var getCustomer = _context.Customers.FirstOrDefault(c => c.EmailAddress == customer.EmailAddress);

    //    if (getCustomer?.Accounts!.Count == 0)
    //    {
    //        getCustomer.Accounts.Add(new(99_000m));
    //        _context.SaveChanges();
    //    }

    //    var customers1 = _context.Customers.ToList();

    //    //var customerSender = customers[0]!.Accounts[0];
    //    //var customerReceiver = customers[1]!.Accounts[0];

    //    //var transaction = customerSender.TransferMoney(customerReceiver, 200);

    //    //if (_context.Find<Transaction>(transaction.TransactionId) is null)
    //    //{
    //    //    _context.Transactions.Add(transaction);
    //    //    _context.SaveChanges();
    //    //}

    //    return View();
    //}

    #endregion
}
