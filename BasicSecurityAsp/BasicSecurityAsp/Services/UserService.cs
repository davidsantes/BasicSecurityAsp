using BasicSecurityAsp.Models;

namespace BasicSecurityAsp.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>()
        {
            new User(){ Email = "david@hotmail.com", Password = "123456" },
            new User(){ Email = "david@hotmail2.com", Password = "123456" }
        };

        public bool IsUser(string email, string password) =>
            users.Any(d => d.Email == email && d.Password == password);
    }
}