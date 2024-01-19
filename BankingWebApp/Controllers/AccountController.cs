using BankingWebApp.Base;
using BankingWebApp.Settings;
using BankingWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace BankingWebApp.Controllers;

public class AccountController : BaseController<AccountController>
{
    private TransactionRepository _transactionRepo;
    private AccountRepository _accountRepo;
    private readonly ISessionManager _sessionManager;

    public AccountController(ILogger<AccountController> logger, AccountRepository accountRepo, ISessionManager sessionManager, TransactionRepository transactionRepo) : base(logger)
    {
        _accountRepo = accountRepo;
        _sessionManager = sessionManager;
        _transactionRepo = transactionRepo;
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
        var getCustomer = _accountRepo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == userId)!.Customer;

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

        var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();

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

    [HttpGet]
    public IActionResult ManageMoney(bool accountSelected, string selectedAccountType, string responseMessage, string alertType, string showMessage = "invisible")
    {
        int userId = _sessionManager.GetUserData().Id;
        ViewData.SetData("ActiveLink", "ManageMoney");

        var getCustomer = _accountRepo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == userId)!.Customer;

        AccountViewModel vm = new AccountViewModel();
        if (accountSelected)
        {
            var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();
            var selectedAccount = allAccounts.FirstOrDefault(a => a.CustomerId == userId && a.AccountType.ToString() == selectedAccountType);
            vm.SelectedAccount = selectedAccount;
        }
        vm.Customer = getCustomer;
        vm.AccountTypes = new();
        foreach (var account in getCustomer!.Accounts!)
        {
            var accountType = account.AccountType.ToString();
            var selectedItem = new SelectListItem(text: accountType, value: accountType);
            vm.AccountTypes.Add(selectedItem);
        }
        ViewData.SetData("CustomerFullName", vm.Customer!.FullName);
        ViewData.SetData("ResponseMessage", responseMessage);
        ViewData.SetData("ShowMessage", showMessage);
        ViewData.SetData("AlertType", alertType);
        return View(vm);
    }

    [HttpPost]
    public IActionResult ManageMoney(string accountTypeSelected)
    {
        int userId = _sessionManager.GetUserData().Id;
        string userFullName = _sessionManager.GetUserData().FullName!;

        var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();

        var selectedAccount = allAccounts.FirstOrDefault(a => a.CustomerId == userId && a.AccountType.ToString() == accountTypeSelected);

        AccountViewModel vm = new();
        vm.SelectedAccount = selectedAccount;
        vm.AccountTypes = new();
        foreach (var account in selectedAccount!.Customer!.Accounts!)
        {
            var accountType = account.AccountType.ToString();
            var selectedItem = new SelectListItem(text: accountType, value: accountType);
            vm.AccountTypes.Add(selectedItem);
        }

        ViewData.SetData("CustomerFullName", userFullName);
        ViewData.SetData("ShowMessage", "invisible");

        return View(vm);
    }

    public IActionResult TransferMoney(string firstName, string lastName, string senderAccountNo, string receiverAccountNo, decimal transferAmount, string accountType)
    {
        string responseMessage = "";
        var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();

        var senderAccount = _accountRepo.GetAccountsWithCustomersAndTransactions().FirstOrDefault(a => a.AccountNo == senderAccountNo);

        var receiverAccount = _accountRepo.GetAccountsWithCustomersAndTransactions()
                                   .FirstOrDefault(a => a.Customer!.FirstName == firstName && a.Customer.LastName == lastName && a.AccountNo == receiverAccountNo);

        if (receiverAccount == null)
        {
            responseMessage = "The account does not exist with our bank";
            return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
        } else
        {
            if (transferAmount <= 0)
            {
                responseMessage = "The transfer amount cannot be less than or equal to zero";
                return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, isError = "visible", alertType = "danger" });
            } else if (senderAccount!.Balance - transferAmount < 0)
            {
                responseMessage = "The transfer amount exceeds your current available balance";
                return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            }

            var transaction = senderAccount.TransferMoney(receiverAccount, transferAmount);
            _transactionRepo.Insert(transaction);
            _transactionRepo.Save();

            responseMessage = "Your funds have been successfully transferred";
            return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
        }
    }

    public IActionResult DepositMoney(string accountNo, decimal depositAmount, string accountType)
    {
        string responseMessage = "";
        var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();

        var account = _accountRepo.GetAccountsWithCustomersAndTransactions().FirstOrDefault(a => a.AccountNo == accountNo);

        if (account == null)
        {
            responseMessage = "The account details are incorrect";
            return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
        } else
        {
            if (depositAmount <= 0)
            {
                responseMessage = "The deposit amount cannot be less than or equal to zero";
                return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            } else if (depositAmount + account.Balance > 1_000_000_000)
            {
                responseMessage = "The deposit amount added to your available balance exceeds the maximum deposit limit";
                return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            }

            account.DepositMoney(depositAmount);
            _accountRepo.Save();

            responseMessage = "Your funds have been successfully deposited";
            return RedirectToAction(nameof(ManageMoney), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
        }
    }
}
