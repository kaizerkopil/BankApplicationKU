
namespace BankingWebApp.Services
{
    public class SessionManager : ISessionManager
    {
        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext!.Session;
        }
        public void SetUserData(UserData userData)
        {
            _session.SetInt32("UserId", userData.Id);
            _session.SetString("UserFullName", userData.FullName!);
        }

        public UserData GetUserData()
        {
            var userId = _session.GetInt32("UserId");
            var userName = _session.GetString("UserFullName");

            if (userId is not null)
            {
                UserData userData = new();
                userData.Id = (int)userId;
                userData.FullName = userName;
                return userData;
            } else
            {
                throw new ArgumentNullException("UserId", $"The value has not been set yet");
            }
        }
    }
}
