namespace BankingWebApp.Settings
{
    public class CustomApiSettings
    {
        public int NumberOfValidItems { get; set; }
        public PersonAddress? PersonAddress { get; set; }
    }

    public class PersonAddress
    {
        public string? City { get; set; }
        public string? Phonenum { get; set; }
        public bool IsAlive { get; set; }
    }
}
