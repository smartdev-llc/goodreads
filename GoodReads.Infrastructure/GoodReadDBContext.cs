using GoodReads.Domain.Books;
using GoodReads.Domain.Users;
using GoodReads.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GoodReads.Infrastructure
{
    public class GoodReadDBContext : DbContext
    {
        public GoodReadDBContext(DbContextOptions<GoodReadDBContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
