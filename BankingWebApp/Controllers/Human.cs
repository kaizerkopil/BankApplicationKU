namespace BankingWebApp.Controllers
{
    public class Human
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int age) => (FirstName, LastName, Age) = (firstName, lastName, age);

        public void Greet()
        {
            if (FirstName == null || LastName == null)
            {
                throw new ArgumentNullException();
            }

            if (FirstName != string.Empty && LastName != string.Empty && !(Age < 0) && Age != 0)
            {
                Console.WriteLine($"Hi my name is {FirstName} {LastName}. I'm {Age} years old.");
            }
        }
    }
}
