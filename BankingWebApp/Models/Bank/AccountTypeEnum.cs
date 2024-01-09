namespace BankingWebApp.Models.Bank
{
    public enum AccountTypeEnum
    {
        [Display(Name = "None")]
        None,

        [Display(Name = "Savings")]
        Savings,

        [Display(Name = "Debit")]
        Debit
    }
}
