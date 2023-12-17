
namespace BankingWebApp.Base
{
    public class BaseController<T> : Controller where T : class
    {
        protected readonly ILogger<T> _logger;

        public BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
