using BankingWebApp.Base;
using Microsoft.AspNetCore.Mvc;

namespace BankingWebApp.Controllers;

public class CustomerController : BaseController<CustomerController>
{
    private CustomerRepository _repo;

    public CustomerController(ILogger<CustomerController> logger, CustomerRepository repo) : base(logger)
    {
        _repo = repo;
    }

    //[Bind("FirstName", "LastName")] 
    public IActionResult RegisterCustomer(Customer customer, float floatVal, int intVal)
    {
        _logger.LogCritical($" {this.GetType()} {nameof(RegisterCustomer)} page ran");
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
