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
    private readonly ISessionManager _sessionManager;

    public AccountController(ILogger<AccountController> logger, AccountRepository repo, ISessionManager sessionManager) : base(logger)
    {
        _repo = repo;
        _sessionManager = sessionManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return Content("Account Index Get");
    }

    [HttpPost]
    public IActionResult Index(int id, string accountSelected)
    {
        return Content("Account Index Post");
    }

    #region AccountController: ShowTransactions
    [HttpGet]
    public IActionResult ShowTransactions()
    {
        int userId = _sessionManager.GetUserData().Id;

        ViewData.SetData("ActiveLink", "ShowTransactions");
        var getCustomer = _repo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == userId)!.Customer;

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
    public IActionResult ShowTransactions(string accountTypeSelected)
    {
        int userId = _sessionManager.GetUserData().Id;
        string userFullName = _sessionManager.GetUserData().FullName!;

        var allAccounts = _repo.GetAccountsWithCustomersAndTransactions();

        var selectedAccount = allAccounts.FirstOrDefault(a => a.CustomerId == userId && a.AccountType.ToString() == accountTypeSelected);

        List<Transaction> AllTransactions = new();

        if (selectedAccount != null)
        {
            AllTransactions = selectedAccount.DebitTransactions!.Concat(selectedAccount.CreditTransactions!).ToList();
        }

        AccountViewModel vm = new();
        vm.SelectedAccount = selectedAccount;
        vm.Transactions = AllTransactions;
        vm.AccountTypes = new();
        foreach (var account in selectedAccount!.Customer!.Accounts!)
        {
            var accountType = account.AccountType.ToString();
            var selectedItem = new SelectListItem(text: accountType, value: accountType);
            vm.AccountTypes.Add(selectedItem);
        }

        ViewData.SetData("CustomerFullName", userFullName);

        return View(vm);
    }
    #endregion 

}
