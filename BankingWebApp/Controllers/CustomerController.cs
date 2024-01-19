using BankingWebApp.Base;
using BankingWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingWebApp.Controllers;

public class CustomerController : BaseController<CustomerController>
{
    private CustomerRepository _customerRepo;
    private AccountRepository _accountRepo;

    private ISessionManager _sessionManager;
    public CustomerController(ILogger<CustomerController> logger, CustomerRepository customerRepo, AccountRepository accountRepo, ISessionManager sessionManager) : base(logger)
    {
        _customerRepo = customerRepo;
        _accountRepo = accountRepo;
        _sessionManager = sessionManager;
    }

    #region CustomerController: RegisterCustomer
    [HttpGet]
    public IActionResult RegisterCustomer()
    {
        return View(new CustomerViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RegisterCustomer([Bind("FirstName", "LastName", "EmailAddress", "Password", "ConfirmPassword", "Phonenum", "StreetAddress", "PostCode", "City", "RegistrationDate")] Customer customer)
    {
        var x = customer;
        if (!ModelState.IsValid)
        {
            List<string> invalidPropNames = new();

            foreach (var modelStateEntry in ModelState)
            {
                if (modelStateEntry.Value.ValidationState == ModelValidationState.Invalid)
                    invalidPropNames.Add(modelStateEntry.Key.Replace("customer.", ""));
            }

            CustomerViewModel vm = new();
            vm.InvalidPropNames = invalidPropNames;
            vm.Customer = customer;
            return View(vm);
        }

        var fetchCustEmail = _customerRepo.GetCustomerByEmail(customer.EmailAddress!);


        if (fetchCustEmail != null)
        {
            CustomerViewModel vm = new();
            vm.InvalidPropNames!.Add("EmailAddress");
            ModelState.AddModelError("customer.EmailAddress", "Email already exists. Please choose a different Email");
            return View(vm);
        } else
        {
            _logger.LogInformation($"Email not found. So, registering customer with email: {customer.EmailAddress}");
            _customerRepo.Insert(customer);
            _customerRepo.Save();
            var fetchCust = _customerRepo.GetCustomerByEmail(customer.EmailAddress!);
            return RedirectToAction("OpenAccount", new { id = fetchCust.CustomerId });
        }
    }
    #endregion

    #region OpenAccount

    [HttpGet]
    public IActionResult OpenAccount(int id)
    {
        var customer = _customerRepo.GetById(id);
        _sessionManager.SetUserData(new() { Id = customer.CustomerId, FullName = customer.FullName });
        ViewData.SetData("CustomerFullName", _sessionManager.GetUserData().FullName!);
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult OpenAccount([Bind("Balance")] Account account, string accountTypeSelected, decimal balance)
    {
        var dbCust = _customerRepo.GetById(_sessionManager.GetUserData().Id);
        ViewData.SetData("CustomerFullName", _sessionManager.GetUserData().FullName!);

        var getEnumValue = Enum.Parse<AccountTypeEnum>(accountTypeSelected);
        account.AccountType = getEnumValue;
        account.Customer = dbCust;

        List<SelectListItem> accountTypes = new List<SelectListItem>()
            {
                new("Savings", "Savings", selected: true),
                new("Debit", "Debit")
            };
        AccountViewModel accountVM = new AccountViewModel(dbCust, accountTypes);
        if (ModelState.IsValid)
        {
            //account.CustomerId = dbCust.CustomerId;
            _accountRepo.Insert(account);
            _accountRepo.Save();
            return RedirectToAction("Index", "Home");
        } else
        {
            string invalidMessage = "";
            if (account.Balance < 0)
            {
                invalidMessage = "Balance cannot be less than zero";
            } else if (account.Balance > 1_000_000_000)
            {
                invalidMessage = "You cannot deposit more than £1,000,000,000 billion pounds";
            }
            ModelState.AddModelError("balanceInvalidMessage", invalidMessage);

            return View(account);
        }
    }
    #endregion

    #region CustomerController: LoginPage
    [HttpGet]
    public IActionResult LoginPage()
    {
        _logger.LogInformation("User has visited the loging page");

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult LoginPage([Bind("EmailAddress, Password")] Customer cust)
    {
        var entriesToValidate = ModelState.Where(x => x.Key == "EmailAddress" || x.Key == "Password");
        var excludeEntries = ModelState.Except(entriesToValidate).ToList();

        excludeEntries.ForEach(e => ModelState.Remove(e.Key));

        if (!ModelState.IsValid) return View(cust);

        try
        {
            var custDb = _customerRepo.GetCustomerByEmailAndPassword(cust.EmailAddress!, cust.Password!);
            return RedirectToAction("Index", "Home", new { id = custDb.CustomerId });
        } catch (Exception)
        {
            ViewData["UserNotFound"] = "No user found with the following Email and Password";
            return View();
        }
    }
    #endregion


}
