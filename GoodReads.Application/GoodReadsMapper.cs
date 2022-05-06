using AutoMapper;
using GoodReads.Domain.Books;
using GoodReads.Domain.Shared;
using GoodReads.Domain.Users;

namespace GoodReads.Application
{
    public class GoodReadsMapper : Profile
    {
        public GoodReadsMapper()
        {
            CreateMap<Book, BookDto>();
        }
    }
}
