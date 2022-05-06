using GoodReads.Application.Abstract;
using GoodReads.Domain.Shared;
using GoodReads.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GoodReads.Infrastructure.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GoodReadDBContext context) : base(context)
        {
        }
    }
}
