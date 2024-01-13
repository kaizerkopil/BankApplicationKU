namespace BankingWebApp.Services
{
    public interface ISessionManager
    {
        void SetUserData(UserData userData);
        UserData GetUserData();
    }
}
