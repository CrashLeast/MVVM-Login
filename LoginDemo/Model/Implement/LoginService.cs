
using LoginDemo.Model.Entity;
using LoginDemo.Model.Interface;

namespace LoginDemo.Model.Implement
{
    public class LoginService : ILoginService
    {
        public bool Login(User user)
        {
            return user.Name == "zszc" && user.Password == "123456";
        }
    }
}