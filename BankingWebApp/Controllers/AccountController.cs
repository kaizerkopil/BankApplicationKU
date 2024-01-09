
using BankingWebApp.Base;
using BankingWebApp.Settings;
using BankingWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace BankingWebApp.Controllers;

public class AccountController : BaseController<AccountController>
{
    private AccountRepository _repo;
    private IOptions<CurrentUser> _user;

    public AccountController(ILogger<AccountController> logger, AccountRepository repo, IOptions<CurrentUser> user) : base(logger)
    {
        _repo = repo;
        _user = user;
    }

    [HttpGet]
    public IActionResult Index(int id)
    {
        id = _user.Value.Id;
        ViewData.SetData("ActiveLink", "ShowTransactions");
        var getCustomer = _repo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == id)!.Customer;

        AccountViewModel vm = new AccountViewModel();
        vm.Customer = getCustomer;
        vm.AccountTypes = new();
        foreach (var account in getCustomer!.Accounts!)
        {
            var accountType = account.AccountType.ToString();
            var selectedItem = new SelectListItem(text: accountType, value: accountType);
            vm.AccountTypes.Add(selectedItem);
        }
        ViewData.SetData("CustomerFullName", vm.Customer!.FullName);

        return View(vm);
    }

    [HttpPost]
    public IActionResult Index(int id, string accountSelected)
    {
        id = _user.Value.Id;

        var allAccounts = _repo.GetAccountsWithCustomersAndTransactions();

        var selectedAccount = allAccounts.FirstOrDefault(a => a.CustomerId == id && a.AccountType.ToString() == accountSelected);

        List<Transaction> AllTransactions = new();

        if (selectedAccount != null)
        {
            AllTransactions = selectedAccount.DebitTransactions!.Concat(selectedAccount.CreditTransactions!).ToList();
        }

        AccountViewModel vm = new();
        vm.SelectedAccount = selectedAccount;
        vm.Transactions = AllTransactions;
        vm.AccountTypes = new();
        foreach (var account in selectedAccount.Customer.Accounts)
        {
            var accountType = account.AccountType.ToString();
            var selectedItem = new SelectListItem(text: accountType, value: accountType);
            vm.AccountTypes.Add(selectedItem);
        }

        ViewData.SetData("CustomerFullName", _user.Value.FullName!);

        return View(vm);
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
