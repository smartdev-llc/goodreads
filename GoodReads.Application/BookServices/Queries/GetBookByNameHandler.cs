using AutoMapper;
using GoodReads.Application.Abstract;
using GoodReads.Domain.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GoodReads.Application.BookServices.Queries
{
    public class GetBookByNameHandler
    {
        private IBookRepository _bookRepository;
        private IMapper _mapper;

        public GetBookByNameHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetBookByNameResponse> SearchAsync(GetBookByNameRequest request)
        {
            var books = await _bookRepository.FindByBookNameAsync(request.BookName);

            if(books == null)
            {
                throw new Exception("No book found.");
            }

            var returnBooks = books.Select(book => _mapper.Map<BookDto>(book)).ToList();

            return new GetBookByNameResponse
            {
                Books = returnBooks
            };
        }
    }
}
