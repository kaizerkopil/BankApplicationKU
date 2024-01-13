using BankingWebApp.Extensions;
using BankingWebApp.Models.Bank;
using Microsoft.EntityFrameworkCore;
using static BankingWebApp.Models.Bank.Account;

namespace BankingWebApp.Database;

public class BankAppDbContext : DbContext
{
    public BankAppDbContext(DbContextOptions<BankAppDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Converting Enum values from respective int values to their string representations
        //modelBuilder
        //    .Entity<Account>()
        //    .Property(e => e.AccountType)
        //    .HasConversion(
        //        v => v.ToString(),
        //        v => Enum.Parse<AccountTypeEnum>(v)
        //    );

        //Adding all the dummy data to modelBuilder using extension method
        modelBuilder.SeedDataUsingModelBuilder();
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}
