using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GoodReads.Application.Abstract
{
    public interface IRepository<TEntity>
         where TEntity : class
    {
        TEntity? GetById(object id);
    }
}
