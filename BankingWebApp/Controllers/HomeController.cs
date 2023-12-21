
using BankingWebApp.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace BankingWebApp.Controllers;

public class HomeController : BaseController<HomeController>
{
    private TransactionRepository _repo;
    public HomeController(ILogger<HomeController> logger, TransactionRepository repo) : base(logger)
    {
        _repo = repo;
    }

    #region HomeController: Login Page
    [HttpGet]
    public IActionResult LoginPage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LoginPage([Bind("Email, Password")] Customer cust)
    {
        var entriesToValidate = ModelState.Where(x => x.Key == "EmailAddress" || x.Key == "Password");
        var excludeEntries = ModelState.Except(entriesToValidate).ToList();

        excludeEntries.ForEach(e => ModelState.Remove(e.Key));

        if (!ModelState.IsValid) return View(cust);

        return RedirectToAction("Index", "Home", new { id = cust.CustomerId });
    }
    #endregion

    [HttpGet]
    public IActionResult Index(int id)
    {
        //ViewData["Current"] = "Home";
        //setting link of navbar item to current page
        ViewData.SetData("ActiveLink", "Home");

        var transactions = _repo.GetAll();
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
