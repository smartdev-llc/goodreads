using GoodReads.Domain.Shared;
using GoodReads.Domain.Users;

namespace GoodReads.Domain.Books
{
    public partial class Book : BaseEntity
    {
        public User User { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public BookStatus BookStatus { get; set; }
    }
}
