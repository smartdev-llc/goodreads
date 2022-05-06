using System.Threading.Tasks;

namespace GoodReads.Application.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
