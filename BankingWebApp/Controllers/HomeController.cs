
using BankingWebApp.Base;
using Microsoft.AspNetCore.Mvc;
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
    [Route("/")]

    public IActionResult Index()
    {
        _logger.LogTrace($"0 - Logging Trace level message");
        _logger.LogDebug($"1 - Logging Debug level message");
        _logger.LogInformation($"2 - Logging Information level message");
        _logger.LogWarning($"3 - Logging Debug Warning message");
        _logger.LogError($"4 - Logging Debug Error message");
        _logger.LogCritical($"5 - Logging Debug Critical message");

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
    #endregion

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
