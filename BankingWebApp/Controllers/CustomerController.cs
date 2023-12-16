using Microsoft.AspNetCore.Mvc;

namespace BankingWebApp.Controllers;

public class CustomerController : Controller
{
    //[Bind("FirstName", "LastName")] 
    public IActionResult RegisterCustomer(Customer customer, float floatVal, int intVal)
    {
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
}
