namespace GoodReads.Domain.Shared
{
    public  class BookDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public BookStatus BookStatus { get; set; }
    }
}
