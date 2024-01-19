using BankingWebApp.Base;
using BankingWebApp.Settings;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace BankingWebApp.Controllers;

public class HomeController : BaseController<HomeController>
{
    private CustomerRepository _repo;
    private readonly ISessionManager _sessionManager;

    public HomeController(ILogger<HomeController> logger, CustomerRepository repo, ISessionManager sessionManager) : base(logger)
    {
        _sessionManager = sessionManager;
        _repo = repo;
    }

    #region HomePage
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
    #endregion

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
