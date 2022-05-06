using AutoMapper;
using GoodReads.Application.Abstract;
using GoodReads.Domain.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GoodReads.Application.BookServices.Queries
{
    public class GetAllReadBookHandler
    {
        private IBookRepository _bookRepository { get; set; }
        private IMapper _mapper;
        public GetAllReadBookHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetAllReadBookResponse> GetAllCompletedReadBookAsync(GetAllReadBookRequest request)
        {
            var books = await _bookRepository.GetAllCompletedReadBookAsync(request.UserId);

            if(books == null)
            {
                throw new Exception("No book found.");
            };
            var returnBooks = books.Select(book => _mapper.Map<BookDto>(book)).ToList();

            return new GetAllReadBookResponse
            {
                Books = returnBooks
            };
        }
    }
}
