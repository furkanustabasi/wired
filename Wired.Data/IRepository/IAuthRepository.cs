using Wired.Data.Entities;

namespace Wired.Data.IRepository
{
    public interface IAuthRepository
    {
        User UserByEmail(string email);
        int Add(User user);
    }
}
