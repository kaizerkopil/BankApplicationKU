
namespace BankingWebApp.Models.Bank;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Display(Name = "First Name")]
    [Length(1, 25)]
    public string? FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Length(1, 25)]
    public string? LastName { get; set; }

    [Display(Name = "Email")]
    [Length(10, 40)]
    public string? EmailAddress { get; set; }

    [Display(Name = "Password")]
    [Length(10, 40)]
    public string? Password { get; set; }

    [Display(Name = "Phone number")]
    [Length(1, 11)]
    public string? Phonenum { get; set; }

    [Display(Name = "Street Address")]
    [Length(1, 50)]
    public string? StreetAddress { get; set; }

    [Display(Name = "Postcode")]
    [Length(1, 15)]
    public string? PostCode { get; set; }

    [Display(Name = "City")]
    [Length(1, 15)]
    public string? City { get; set; }

    [Display(Name = "Date Registered")]
    public DateTime RegistrationDate { get => DateTime.Now; }
    public List<Account>? Accounts { get; set; } = new();

    [NotMapped]
    public string FullName { get => $"{FirstName} {LastName}"; }

    [NotMapped]
    public string FullAddress { get => $"{StreetAddress}, {City}, {PostCode}"; }


    public Customer()
    {

    }

    public Customer(string? firstName, string? lastName, string? emailAddress, string? phonenum, string? streetAddress, string? postCode, string? city)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        Phonenum = phonenum;
        StreetAddress = streetAddress;
        PostCode = postCode;
        City = city;
    }
}
