using GoodReads.Application.Abstract;
using System;
using System.Threading.Tasks;

namespace GoodReads.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GoodReadDBContext goodReadDBContext;

        public UnitOfWork(GoodReadDBContext goodReadDBContext)
        {
            this.goodReadDBContext = goodReadDBContext;
        }

        public async Task CommitAsync()
        {
            try
            {
                await goodReadDBContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
