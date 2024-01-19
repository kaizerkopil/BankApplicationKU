using System.ComponentModel;
using System.Security.Cryptography.Xml;
namespace BankingWebApp.Models.Bank;

[PrimaryKey(nameof(AccountId))]
public class Account
{
    public int AccountId { get; set; }

    [Display(Name = "Account Number")]
    public string AccountNo { get => CreateAccountNumber(); }

    [Precision(15, 3)]
    [Range(0, 1_000_000_000)]
    public decimal Balance { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    [InverseProperty(nameof(Transaction.Receiver))]
    public List<Transaction>? DebitTransactions { get; set; } = new();

    [InverseProperty(nameof(Transaction.Sender))]
    public List<Transaction>? CreditTransactions { get; set; } = new();

    //[EnumDataType(typeof(AccountTypeEnum))]
    [Column(TypeName = "nvarchar(50)")]
    public AccountTypeEnum AccountType { get; set; } = AccountTypeEnum.None;

    [NotMapped]
    public List<Account> SavedAccounts { get; set; } = new();

    public Account()
    {

    }

    public Account(decimal balance)
    {
        Balance = balance;
    }

    public Account(int accountId, int customerId, decimal balance, AccountTypeEnum accountType)
    {
        AccountId = accountId;
        CustomerId = customerId;
        Balance = balance;
        AccountType = accountType;
    }

    private string CreateAccountNumber()
    {
        var tempNumber = 100_000 + AccountId;
        string accountNumber = tempNumber.ToString().Insert(2, "-").Insert(5, "-");
        return accountNumber.ToString();
    }

    public Transaction TransferMoney(Account receiver, decimal amount)
    {
        if (receiver is null)
        {
            throw new ArgumentNullException(nameof(receiver));
        }

        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Transfer amount cannot be less than or equal to zero");

        if (amount > Balance) throw new ArgumentOutOfRangeException(nameof(amount), $"The transfer amount ${amount} exceeds the current balance");

        this.Balance -= amount;
        receiver.Balance += amount;

        return new Transaction(this, receiver, amount, DateTime.Now);
    }

    public Transaction DepositMoney(decimal depositAmount)
    {
        if (depositAmount <= 0) throw new ArgumentOutOfRangeException(nameof(depositAmount), "Deposit amount cannot be less than or equal to zero");

        if (depositAmount + this.Balance >= 1_000_000_000)
        {
            throw new ArgumentOutOfRangeException(nameof(depositAmount), "The deposit amount added to your available balance exceeds the maximum deposit limit");
        }

        this.Balance += depositAmount;

        return new Transaction(this, depositAmount, DateTime.Now);
    }

    public Transaction WithdrawMoney(decimal withdrawAmount)
    {
        if (withdrawAmount <= 0) throw new ArgumentOutOfRangeException(nameof(withdrawAmount), "Withdrawal amount cannot be less than or equal to zero");

        if (withdrawAmount > this.Balance)
        {
            throw new ArgumentOutOfRangeException(nameof(withdrawAmount), "The withdraw amount cannot exceed your available balance");
        }

        this.Balance -= withdrawAmount;

        return new Transaction(this, withdrawAmount, DateTime.Now, true);
    }

    public Transaction TransferMoney(int transactionId, Account receiver, decimal amount)
    {
        if (receiver is null)
        {
            throw new ArgumentNullException(nameof(receiver));
        }

        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than or equal to zero");

        if (amount > Balance) throw new ArgumentOutOfRangeException(nameof(amount), $"The amount ${amount} exceeds the current balance");

        this.Balance -= amount;
        receiver.Balance += amount;

        return new Transaction(transactionId, this.AccountId, receiver.AccountId, amount, DateTime.Now);
    }


}
