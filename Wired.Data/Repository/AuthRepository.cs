using System.Linq;
using Wired.Data.Context;
using Wired.Data.Entities;
using Wired.Data.IRepository;

namespace Wired.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly WiredContext _context;

        public AuthRepository(WiredContext context)
        {
            _context = context;
        }
        public User UserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }

        public int Add(User user)
        {
            var response = _context.Users.Add(user);
            _context.SaveChanges();
            return response.Entity.Id;
        }
    }
}
