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
    private readonly ISessionManager _sessionManager;

    public HomeController(ILogger<HomeController> logger, CustomerRepository repo, IOptions<CurrentUser> user, ISessionManager sessionManager) : base(logger)
    {
        _user = user;
        _sessionManager = sessionManager;
        _repo = repo;
    }


    [HttpGet]
    public IActionResult Index(int id)
    {
        if (id != 0)
        {
            //retrieving customer from database
            var custDb = _repo.GetById(id);
            //assigning customer Id and FullName to HttpContext.Session such that the data persists across User's session
            _sessionManager.SetUserData(new UserData(custDb.CustomerId, custDb.FullName));
        }

        var userId = _sessionManager.GetUserData().Id;
        var userFullName = _sessionManager.GetUserData().FullName;

        //setting link of navbar item to current page
        ViewData.SetData("ActiveLink", "Home");
        //setting Customer FullName to footer anchor tag element innerText
        ViewData.SetData("CustomerFullName", userFullName!);

        _logger.LogInformation("User has successfully logged in");
        //this will display the LoginPage.cshtml view
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
