using GoodReads.Domain.Shared;

namespace GoodReads.Domain.Books
{
    public partial class Book
    {
        public Book(string Name,
                    string AuthorName,
                    BookStatus bookStatus)
        {
            this.Update(Name, AuthorName, bookStatus);
        }

        public void Update(string name,
                           string authorName,
                           BookStatus bookStatus)
        {
            Name = name;
            AuthorName = authorName;
            BookStatus = bookStatus;
        }
    }
}
