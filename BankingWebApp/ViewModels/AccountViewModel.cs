using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingWebApp.ViewModels
{
    public class AccountViewModel
    {
        public Customer? Customer { get; set; }
        public List<SelectListItem>? AccountTypes { get; set; }
        public Account? SelectedAccount { get; set; }
        public List<Transaction>? Transactions { get; set; }
    }
}
