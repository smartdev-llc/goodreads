using GoodReads.Domain.Shared;
using System.Collections.Generic;

namespace GoodReads.Application.BookServices.Queries
{
    public class GetAllReadBookResponse
    {
        public List<BookDto> Books { get; set; }
    }
}
