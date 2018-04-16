
using LoginDemo.Model.Entity;

namespace LoginDemo.Model.Interface
{
    public interface ILoginService
    {
        bool Login(User user);
    }
}