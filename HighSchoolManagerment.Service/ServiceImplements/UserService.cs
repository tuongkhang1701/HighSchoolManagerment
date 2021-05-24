using HighSchoolManagerment.Application.Interfaces;
using System.Linq;

namespace HighSchoolManagerment.Application.Implements
{
    public class UserService : EFRepository<User, int>, IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public User FindByEmail(string email)
        {
            return _context.Users.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}