using GoodReads.Api.Dto;
using GoodReads.Application.UserServices.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GoodReads.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private AddBookHandler _addBookHandler { get; set; }

        public UsersController(AddBookHandler addBookHandler)
        {
            _addBookHandler = addBookHandler;
        }
        /// <summary>
        /// Add new book to list of books user have read
        /// </summary>
        /// <param name="UserId">Id of User</param>
        /// <param name="request">request DTO</param>
        /// <returns></returns>
        /// 
        [HttpPost("{UserId}")]
        public async Task<IActionResult> AddBook(
            int UserId,
            [FromBody] AddBookRequestDto request)
        {
            var newBook = new AddBookRequest()
            {
                UserId = UserId,
                AuthorName = request.AuthorName,
                Name = request.BookName,
            };
            return Ok(await _addBookHandler.AddBookAsync(newBook));
        }
    }
}
