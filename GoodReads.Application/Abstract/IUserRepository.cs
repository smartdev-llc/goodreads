using GoodReads.Domain;
using GoodReads.Domain.Books;
using GoodReads.Domain.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodReads.Application.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
