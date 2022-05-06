using GoodReads.Application.Abstract;
using GoodReads.Domain.Books;
using GoodReads.Domain.Shared;
using System;
using System.Threading.Tasks;

namespace GoodReads.Application.UserServices.Commands
{
    public class AddBookHandler
    {
        private IUserRepository _userRepository;
        private IBookRepository _bookRepository;
        private IUnitOfWork _unitOfWork;
        public AddBookHandler(IUnitOfWork unitOfWork,
                              IUserRepository userRepository,
                              IBookRepository bookRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddBookResponse> AddBookAsync(AddBookRequest request)
        {
            var user = _userRepository.GetById(request.UserId);
            if (user == null)
            {
                throw new Exception("User Not Found");
            };

            var book = new Book(
                request.Name,
                request.AuthorName,
                BookStatus.FinishedReading);

            user.Books.Add(book);
            await _unitOfWork.CommitAsync();

            return new AddBookResponse()
            {
                Name = request.Name,
                AuthorName = request.AuthorName,
                UserId = request.UserId,
            };
        }
    }
}
