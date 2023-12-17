namespace BankingWebApp.Extensions;

public static class SeedDataExtension
{
    public static void InitalizeDatabaseInStartUp(IServiceProvider sp)
    {
        using (var context = new BankAppDbContext(sp.GetRequiredService<DbContextOptions<BankAppDbContext>>()))
        {
            context.Database.Migrate();

            if (context.Customers.Any())
            {
                return; // Means data already exists
            }

            var firstCustomer = new Customer
            {
                FirstName = "John",
                LastName = "Gerrad",
                Phonenum = "07705089501",
                EmailAddress = "john.gerrad@gmail.com",
                Password = "1234",
                Accounts = new() { }
            };

            var firstCustAcc = new Account(50_000.00m);
            firstCustomer.Accounts.Add(firstCustAcc);

            var secondCustomer = new Customer
            {
                FirstName = "Pattrick",
                LastName = "George",
                Phonenum = "07755589511",
                EmailAddress = "pattrick.george@outlook.com",
                Password = "5678",
                Accounts = new() { }
            };

            var secondCustAcc = new Account(100_000.00m);
            secondCustomer.Accounts.Add(secondCustAcc);

            var thirdCustomer = new Customer
            {
                FirstName = "Lilliana",
                LastName = "Johnson",
                Phonenum = "07712312355",
                EmailAddress = "lilliana.bestie@hotmail.com",
                Password = "9101112",
                Accounts = new() { }
            };

            var thirdCustAcc = new Account(150_000.00m);
            thirdCustomer.Accounts.Add(thirdCustAcc);

            context.Customers.AddRange(firstCustomer, secondCustomer, thirdCustomer);

            context.Transactions.AddRange(
                firstCustAcc.TransferMoney(secondCustAcc, 1000),//credit, second-debit
                firstCustAcc.TransferMoney(secondCustAcc, 3000),//credit, second-debit

                firstCustAcc.TransferMoney(thirdCustAcc, 5000), //credit, third-debit

                secondCustAcc.TransferMoney(firstCustAcc, 6000), //second-credit, first-debit, 
                secondCustAcc.TransferMoney(thirdCustAcc, 15000), //second-credit, third - debit, 

                thirdCustAcc.TransferMoney(firstCustAcc, 5000), //third-credit, first - debit
                thirdCustAcc.TransferMoney(secondCustAcc, 8000)//third-credit, second-debit
            );

            context.SaveChanges();
        };
    }

    public static void SeedDataUsingModelBuilder(this ModelBuilder builder)
    {

        var firstCustomer = new Customer
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Gerrad",
            Phonenum = "07705089501",
            EmailAddress = "john.gerrad@gmail.com",
            Password = "1234",
            Accounts = new() { }
        };

        var firstCustAcc = new Account(1, 1, 50_000.00m);
        //firstCustomer.Accounts.Add(firstCustAcc);

        var secondCustomer = new Customer
        {
            CustomerId = 2,
            FirstName = "Pattrick",
            LastName = "George",
            Phonenum = "07755589511",
            EmailAddress = "pattrick.george@outlook.com",
            Password = "5678",
            Accounts = new() { }
        };

        var secondCustAcc = new Account(2, 2, 100_000.00m);
        //secondCustomer.Accounts.Add(secondCustAcc);

        var thirdCustomer = new Customer
        {
            CustomerId = 3,
            FirstName = "Lilliana",
            LastName = "Johnson",
            Phonenum = "07712312355",
            EmailAddress = "lilliana.bestie@hotmail.com",
            Password = "9101112",
            Accounts = new() { }
        };

        var thirdCustAcc = new Account(3, 3, 150_000.00m);
        //thirdCustomer.Accounts.Add(thirdCustAcc);

        builder.Entity<Customer>().HasData(firstCustomer, secondCustomer, thirdCustomer);
        builder.Entity<Account>().HasData(firstCustAcc, secondCustAcc, thirdCustAcc);

        builder.Entity<Transaction>().HasData(
            firstCustAcc.TransferMoney(1, secondCustAcc, 1000),//credit, second-debit
            firstCustAcc.TransferMoney(2, secondCustAcc, 3000),//credit, second-debit

            firstCustAcc.TransferMoney(3, thirdCustAcc, 5000), //credit, third-debit

            secondCustAcc.TransferMoney(4, firstCustAcc, 6000), //second-credit, first-debit, 
            secondCustAcc.TransferMoney(5, thirdCustAcc, 15000), //second-credit, third - debit, 

            thirdCustAcc.TransferMoney(6, firstCustAcc, 5000), //third-credit, first - debit
            thirdCustAcc.TransferMoney(7, secondCustAcc, 8000)//third-credit, second-debit
        );
    }
}
