namespace BankingWebApp.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public string? FullName { get; set; }

        public UserData()
        {

        }

        public UserData(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}
