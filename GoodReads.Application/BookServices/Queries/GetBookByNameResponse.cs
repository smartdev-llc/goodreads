using GoodReads.Domain.Shared;
using System.Collections.Generic;

namespace GoodReads.Application.BookServices.Queries
{
    public class GetBookByNameResponse
    {
        public List<BookDto> Books { get; set; }
    }
}