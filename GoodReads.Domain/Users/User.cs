using GoodReads.Domain;
using GoodReads.Domain.Books;
using System.Collections.Generic;

namespace GoodReads.Domain.Users
{
    public partial class User : BaseEntity
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
