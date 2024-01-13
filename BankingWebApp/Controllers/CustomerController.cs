using BankingWebApp.Base;
using Microsoft.AspNetCore.Mvc;

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

    //[Bind("FirstName", "LastName")] 
    public IActionResult RegisterCustomer(Customer customer, float floatVal, int intVal)
    {
        var customers = _repo.GetCustomersWithAccountsAndTransactions();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RegisterCustomerPost(Customer customer)
    {
        if (ModelState.IsValid)
        {

        }

        return View(customer);
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
    public IActionResult LoginCustomer()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult LoginCustomer([Bind("EmailAddress", "Password")] Customer customer)
    {
        return View();
    }
}
