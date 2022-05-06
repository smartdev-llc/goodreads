using GoodReads.Application.Abstract;
using GoodReads.Domain.Books;
using GoodReads.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodReads.Infrastructure.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(GoodReadDBContext context) : base(context)
        {
        }

        public async Task<List<Book>> FindByBookNameAsync(string bookName)
            => await DbSet
            .Where(x => x.Name.Contains(bookName)).ToListAsync();

        public async Task<List<Book>> GetAllCompletedReadBookAsync(int userId)
            => await DbSet
            .Where(x => x.UserId == userId
            && x.BookStatus == BookStatus.FinishedReading).ToListAsync();
    }
}
