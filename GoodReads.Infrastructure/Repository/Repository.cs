namespace GoodReads.Infrastructure.Repository
{
    using GoodReads.Application.Abstract;
    using Microsoft.EntityFrameworkCore;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected GoodReadDBContext Context { get; }

        protected DbSet<TEntity> DbSet { get; }

        public Repository(GoodReadDBContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }
        public virtual TEntity GetById(object id) => DbSet.Find(id);
    }
}
