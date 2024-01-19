namespace BankingWebApp.ViewModels
{
    public class CustomerViewModel
    {
        public List<string>? InvalidPropNames { get; set; } = new();
        public Customer? Customer { get; set; }
    }
}
