﻿
using Microsoft.AspNetCore.Mvc;

namespace BankingWebApp.Controllers;

public class AccountController : Controller
{
    private readonly BankAppDbContext _context;

    public AccountController(BankAppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }




    public IActionResult UserAccount()
    {
        var customerToRemove = _context.Find<Customer>(9);
        if (customerToRemove is not null)
        {
            _context.Remove<Customer>(customerToRemove);
            _context.SaveChanges();
        }

        //ThenInclude DebitTransactions makes such that it also ThenIncludes CreditTransactions
        //var customers = _context.Customers.Include(c => c.Accounts).ThenInclude(a => a.DebitTransactions).ToList();

        //Include CreditTransactions or DebitTransactions makes it such that it includes the other 
        //Include Customer makes it such it populates the Customer details
        var accounts = _context.Accounts.Include(a => a.Customer).Include(a => a.CreditTransactions).ToList();
        var transactions = _context.Transactions.ToList();

        var customer = new Customer("Narul", "Ahmed", "narum@gg.com", string.Empty, string.Empty, string.Empty, string.Empty);

        var doCustomerExist = _context.Customers.FirstOrDefault(c => c.EmailAddress == customer.EmailAddress);

        if (doCustomerExist is null)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        var getCustomer = _context.Customers.FirstOrDefault(c => c.EmailAddress == customer.EmailAddress);

        if (getCustomer?.Accounts!.Count == 0)
        {
            getCustomer.Accounts.Add(new(99_000m));
            _context.SaveChanges();
        }

        var customers1 = _context.Customers.ToList();

        //var customerSender = customers[0]!.Accounts[0];
        //var customerReceiver = customers[1]!.Accounts[0];

        //var transaction = customerSender.TransferMoney(customerReceiver, 200);

        //if (_context.Find<Transaction>(transaction.TransactionId) is null)
        //{
        //    _context.Transactions.Add(transaction);
        //    _context.SaveChanges();
        //}

        return View();
    }
}
