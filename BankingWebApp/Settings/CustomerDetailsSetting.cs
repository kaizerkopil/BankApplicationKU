namespace BankingWebApp.Settings
{
    public class CustomerDetailsSetting
    {
        public string? FullName { get; set; }
        public Location? Location { get; set; }
        public decimal? Balance { get; set; }
        public string? PostCode { get; set; }
        public string? FirstLineAddress { get; set; }
    }

    public class Location
    {
        public double? Lat { get; set; }
        public double? Lon { get; set; }
    }
}
