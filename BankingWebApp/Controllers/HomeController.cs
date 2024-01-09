using BankingWebApp.Base;
using BankingWebApp.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace BankingWebApp.Controllers;

public class HomeController : BaseController<HomeController>
{
    private CustomerRepository _repo;
    private IOptions<CurrentUser> _user;
    public HomeController(ILogger<HomeController> logger, CustomerRepository repo, IOptions<CurrentUser> user) : base(logger)
    {
        _user = user;
        _repo = repo;
    }

    #region HomeController: Login Page
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
    public IActionResult Index(int id)
    {
        if (id != 0) _user.Value.Id = id;

        //ViewData["Current"] = "Home";
        //setting link of navbar item to current page
        ViewData.SetData("ActiveLink", "Home");

        var custDb = _repo.GetById(_user.Value.Id);
        _user.Value.FullName = custDb.FullName;
        ViewData["CustomerFullName"] = custDb.FullName;
        ViewData["CustomerId"] = _user.Value.Id;
        _logger.LogInformation("User has successfully logged in");
        //this will only show the Login Page
        return View();
    }

    [HttpPost]
    public IActionResult Index(string message, string recipientName)
    {
        // Here we will validate the login page "email & password" before showing customer's their Account Page
        return View();
    }


    public IActionResult Privacy()
    {
        ViewData.SetData("ActiveLink", "Privacy");

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
