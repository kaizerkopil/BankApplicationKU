namespace BankingWebApp.Models.Bank
{
    [NotMapped]
    public class SavingAccount : Account
    {
        private decimal InterestRate = 0.05m;

        public SavingAccount() : base()
        {
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public void AddInterestToBalance()
        {
            var interestMoney = Balance * 0.05m;

            Balance += interestMoney;
        }
    }
}
