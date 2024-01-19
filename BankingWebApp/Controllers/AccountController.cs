using BankingWebApp.Base;
using BankingWebApp.Models.Bank;
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
    private CustomerRepository _customerRepo;
    private readonly ISessionManager _sessionManager;

    public AccountController(ILogger<AccountController> logger, AccountRepository accountRepo, ISessionManager sessionManager, TransactionRepository transactionRepo, CustomerRepository customerRepo) : base(logger)
    {
        _accountRepo = accountRepo;
        _sessionManager = sessionManager;
        _transactionRepo = transactionRepo;
        _customerRepo = customerRepo;
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

        var getAccount = _accountRepo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == userId);

        if (getAccount == null)
        {
            return RedirectToAction("Index", "Home", new { responseMessage = "Error on Showing Transactions: Please open an account with us first", showMessage = "visible" });
        }

        var getCustomer = getAccount?.Customer;

        AccountViewModel vm = new AccountViewModel();
        vm.Customer = getCustomer;
        vm.AccountTypes = new();
        var allCustAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions().Where(a => a.CustomerId == userId);
        foreach (var account in allCustAccounts)
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
    public IActionResult ManageFunds(bool accountSelected, string selectedAccountType, string responseMessage, string alertType, string showMessage = "invisible")
    {
        int userId = _sessionManager.GetUserData().Id;
        ViewData.SetData("ActiveLink", "ManageFunds");

        var getAccount = _accountRepo.GetAccountsWithCustomersAndTransactions()!.FirstOrDefault(a => a.CustomerId == userId);

        if (getAccount == null)
        {
            return RedirectToAction("Index", "Home", new { responseMessage = "Error on Manage Funds: Please open an account with us first", showMessage = "visible" });
        }

        var getCustomer = getAccount?.Customer;

        AccountViewModel vm = new AccountViewModel();
        if (accountSelected)
        {
            var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();
            var selectedAccount = allAccounts.FirstOrDefault(a => a.CustomerId == userId && a.AccountType.ToString() == selectedAccountType);
            vm.SelectedAccount = selectedAccount;
        }
        vm.Customer = getCustomer;
        vm.AccountTypes = new();
        var allCustAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions().Where(a => a.CustomerId == userId);
        foreach (var account in allCustAccounts)
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
    public IActionResult ManageFunds(string accountTypeSelected)
    {
        ViewData.SetData("ActiveLink", "ManageFunds");
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
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
        } else
        {
            if (transferAmount <= 0)
            {
                responseMessage = "The transfer amount cannot be less than or equal to zero";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, isError = "visible", alertType = "danger" });
            } else if (senderAccount!.Balance - transferAmount < 0)
            {
                responseMessage = "The transfer amount exceeds your current available balance";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            }

            var transaction = senderAccount.TransferMoney(receiverAccount, transferAmount);
            _transactionRepo.Insert(transaction);
            _transactionRepo.Save();

            responseMessage = "Your funds have been successfully transferred";
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
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
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
        } else
        {
            if (depositAmount <= 0)
            {
                responseMessage = "The deposit amount cannot be less than or equal to zero";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            } else if (depositAmount + account.Balance > 1_000_000_000)
            {
                responseMessage = "The deposit amount added to your available balance exceeds the maximum deposit limit";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            }

            var depositTransaction = account.DepositMoney(depositAmount);
            _transactionRepo.Insert(depositTransaction);
            _transactionRepo.Save();

            responseMessage = "Your funds have been successfully deposited";
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
        }
    }

    public IActionResult WithdrawMoney(string accountNo, decimal withdrawAmount, string accountType)
    {
        string responseMessage = "";
        var allAccounts = _accountRepo.GetAccountsWithCustomersAndTransactions();

        var account = _accountRepo.GetAccountsWithCustomersAndTransactions().FirstOrDefault(a => a.AccountNo == accountNo);

        if (account == null)
        {
            responseMessage = "The account details are incorrect";
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
        } else
        {
            if (withdrawAmount <= 0)
            {
                responseMessage = "The withdraw amount cannot be less than or equal to zero";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            } else if (withdrawAmount > account.Balance)
            {
                responseMessage = "The withdraw amount exceeds your available balance";
                return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "danger" });
            }

            var depositTransaction = account.WithdrawMoney(withdrawAmount);
            _transactionRepo.Insert(depositTransaction);
            _transactionRepo.Save();

            responseMessage = "Your funds have been successfully withdrawn";
            return RedirectToAction(nameof(ManageFunds), new { accountSelected = true, selectedAccountType = accountType, responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
        }
    }


    [HttpGet]
    public IActionResult ManageProfile(string responseMessage, string alertType, string showMessage = "invisible")
    {
        var currentUserId = _sessionManager.GetUserData().Id;
        string userFullName = _sessionManager.GetUserData().FullName!;
        ViewData.SetData("CustomerFullName", userFullName);

        var customer = _customerRepo.GetCustomersWithAccountsAndTransactions().FirstOrDefault(a => a.CustomerId == currentUserId);

        AccountViewModel vm = new();
        vm.Customer = customer;
        vm.Accounts = customer!.Accounts;

        ViewData.SetData("ResponseMessage", responseMessage);
        ViewData.SetData("ShowMessage", showMessage);
        ViewData.SetData("AlertType", alertType);
        return View(vm);
    }

    [HttpPost]
    public IActionResult ManageProfile()
    {
        ViewData.SetData("ShowMessage", "invisible");
        return View();
    }

    [HttpGet]
    public IActionResult DeleteAccount(int accountId)
    {
        string responseMessage = "";

        var accountToDelete = _accountRepo.GetAccountsWithCustomersAndTransactions().FirstOrDefault(a => a.AccountId == accountId);

        if (accountToDelete is not null)
        {
            List<Transaction> allTransactions = new();
            allTransactions = accountToDelete.DebitTransactions!.Concat(accountToDelete.CreditTransactions!).ToList();
            foreach (var transaction in allTransactions)
            {
                if (transaction.SenderAccountId == accountId || transaction.ReceiverAccountId == accountId)
                {
                    _transactionRepo.Delete(transaction.TransactionId);
                    _transactionRepo.Save();
                }
            }
            _accountRepo.Delete(accountToDelete.AccountId);
            _accountRepo.Save();
            responseMessage = "The account has been deleted successfully";
            return RedirectToAction(nameof(ManageProfile), new { responseMessage = responseMessage, showMessage = "visible", alertType = "success" });
        } else
        {
            responseMessage = "The account selected could not be deleted. Please contact support";
            return RedirectToAction(nameof(ManageProfile), new { responseMessage = responseMessage, showMessage = "visible", alertType = "warning" });
        }
    }

    //[HttpPost]
    //public IActionResult DeleteAccount(int accountId)
    //{
    //    return RedirectToAction(nameof(ManageProfile));
    //}
}
