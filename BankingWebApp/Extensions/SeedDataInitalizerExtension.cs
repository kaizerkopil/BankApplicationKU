using static BankingWebApp.Models.Bank.Account;

namespace BankingWebApp.Extensions;

public static class SeedDataExtension
{
    public static void SeedDataUsingModelBuilder(this ModelBuilder builder)
    {
        //this is being used currently to seed the database
        var firstCustomer = new Customer
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Gerrad",
            Phonenum = "07705089501",
            EmailAddress = "john.gerrad@gmail.com",
            Password = "1111",
            Accounts = new() { }
        };

        var firstCustAcc = new Account(1, 1, 50_000.00m, AccountTypeEnum.Savings);
        var firstCustAcc2 = new Account(4, 1, 25_000.00m, AccountTypeEnum.Debit);
        //firstCustomer.Accounts.Add(firstCustAcc);

        var secondCustomer = new Customer
        {
            CustomerId = 2,
            FirstName = "Pattrick",
            LastName = "George",
            Phonenum = "07755589511",
            EmailAddress = "pattrick.george@outlook.com",
            Password = "2222",
            Accounts = new() { }
        };

        var secondCustAcc = new Account(2, 2, 100_000.00m, AccountTypeEnum.Debit);
        //secondCustomer.Accounts.Add(secondCustAcc);

        var thirdCustomer = new Customer
        {
            CustomerId = 3,
            FirstName = "Lilliana",
            LastName = "Johnson",
            Phonenum = "07712312355",
            EmailAddress = "lilliana.bestie@hotmail.com",
            Password = "3333",
            Accounts = new() { }
        };

        var thirdCustAcc = new Account(3, 3, 150_000.00m, AccountTypeEnum.Debit);
        //thirdCustomer.Accounts.Add(thirdCustAcc);

        builder.Entity<Customer>().HasData(firstCustomer, secondCustomer, thirdCustomer);
        builder.Entity<Account>().HasData(firstCustAcc, firstCustAcc2, secondCustAcc, thirdCustAcc);

        builder.Entity<Transaction>().HasData(
            firstCustAcc.TransferMoney(1, secondCustAcc, 1000),//credit, second-debit
            firstCustAcc.TransferMoney(2, secondCustAcc, 3000),//credit, second-debit
            firstCustAcc.TransferMoney(3, thirdCustAcc, 5000), //credit, third-debit
            firstCustAcc.TransferMoney(13, firstCustAcc2, 6000), //credit, third-debit


            firstCustAcc2.TransferMoney(8, thirdCustAcc, 2000),
            firstCustAcc2.TransferMoney(9, secondCustAcc, 1500),
            firstCustAcc2.TransferMoney(10, firstCustAcc, 5000),


            secondCustAcc.TransferMoney(4, firstCustAcc, 6000), //second-credit, first-debit, 
            secondCustAcc.TransferMoney(5, thirdCustAcc, 15000), //second-credit, third - debit, 
            secondCustAcc.TransferMoney(11, firstCustAcc2, 3000), //second-credit, third - debit, 

            thirdCustAcc.TransferMoney(6, firstCustAcc, 5000), //third-credit, first - debit
            thirdCustAcc.TransferMoney(7, secondCustAcc, 8000),//third-credit, second-debit
            thirdCustAcc.TransferMoney(12, firstCustAcc, 15000) //third-credit, first - debit

        );
    }
}
