using BankingWebApp.Base;
using BankingWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BankingWebApp.Controllers;

public class CustomerController : BaseController<CustomerController>
{
    private CustomerRepository _repo;
    private ISessionManager _sessionManager;
    public CustomerController(ILogger<CustomerController> logger, CustomerRepository repo, ISessionManager sessionManager) : base(logger)
    {
        _repo = repo;
        _sessionManager = sessionManager;
    }

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

        var fetchCustEmail = _repo.GetCustomerByEmail(customer.EmailAddress!);


        if (fetchCustEmail != null)
        {
            CustomerViewModel vm = new();
            vm.InvalidPropNames!.Add("EmailAddress");
            ModelState.AddModelError("customer.EmailAddress", "Email Address already exists. Please choose another Email address");
            return View(vm);
        } else
        {
            _logger.LogInformation($"Email not found. So, registering customer with email: {customer.EmailAddress}");
            _repo.Insert(customer);
            _repo.Save();
            var fetchCust = _repo.GetCustomerByEmail(customer.EmailAddress!);
            return RedirectToAction(nameof(OpenAccount), new { id = fetchCust.CustomerId });
        }
    }

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
            var custDb = _repo.GetCustomerByEmailAndPassword(cust.EmailAddress!, cust.Password!);
            return RedirectToAction("Index", "Home", new { id = custDb.CustomerId });
        } catch (Exception)
        {
            ViewData["UserNotFound"] = "No user found with the following Email and Password";
            return View();
        }
    }
    #endregion

    [HttpGet]
    public IActionResult OpenAccount(int id)
    {
        var customer = _repo.GetById(id);

        return View(customer);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult OpenAccount(Account account)
    {

        return View();
    }
}
