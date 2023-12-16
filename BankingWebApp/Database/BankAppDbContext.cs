using BankingWebApp.Models.Bank;
using Microsoft.EntityFrameworkCore;

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

        modelBuilder.SeedDataUsingModelBuilder();
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

}
