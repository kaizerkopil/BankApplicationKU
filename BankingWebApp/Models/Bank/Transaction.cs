
namespace BankingWebApp.Models.Bank;

public class Transaction
{
    [Key]
    [Column(Order = 0)]
    public int TransactionId { get; set; }

    [Precision(15, 3)]
    [Range(0, 1_000_000_000_000)]
    public decimal Amount { get; set; }

    [Display(Name = "Transaction Date")]
    public DateTime TransactionDate { get; set; }

    [ForeignKey(nameof(Sender)), Column(Order = 1)]
    public int? SenderAccountId { get; set; }

    [ForeignKey(nameof(Receiver)), Column(Order = 2)]
    public int? ReceiverAccountId { get; set; }

    public Account? Sender { get; set; }

    public Account? Receiver { get; set; }

    public Transaction()
    {

    }

    public Transaction(Account sender, Account receiver, decimal amount)
    {
        Sender = sender;
        Receiver = receiver;
        Amount = amount;
    }

    public Transaction(int transactionId, int senderAccountId, int receiverAccountId, decimal amount, DateTime transactionDate)
    {
        TransactionId = transactionId;
        Amount = amount;
        SenderAccountId = senderAccountId;
        ReceiverAccountId = receiverAccountId;
        TransactionDate = transactionDate;
    }
}
