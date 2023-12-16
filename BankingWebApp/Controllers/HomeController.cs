
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BankingWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private BankAppDbContext _context;
    public HomeController(ILogger<HomeController> logger, BankAppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    #region HomeController: Login Page
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string message, string recipientName)
    {
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
