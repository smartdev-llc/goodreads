using GoodReads.Domain;
using GoodReads.Domain.Books;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodReads.Application.Abstract
{
    public interface IBookRepository : IRepository<Book>
    {
        /// <summary>
        /// Find Book depend on Book Name
        /// </summary>
        /// <param name="bookName">Name of Book</param>
        /// <returns>List of book</returns>
        public Task<List<Book>> FindByBookNameAsync(string bookName);

        /// <summary>
        /// Get all of Books that already read.
        /// </summary>
        /// <param name="userId">Id of User</param>
        /// <returns>List of book</returns>
        public Task<List<Book>> GetAllCompletedReadBookAsync(int userId);
    }
}