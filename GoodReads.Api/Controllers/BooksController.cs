using GoodReads.Api.Dto;
using GoodReads.Application.BookServices.Queries;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System.Threading.Tasks;

namespace GoodReads.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private GetBookByNameHandler _getBookByNameHandler;
        private GetAllReadBookHandler _getAllReadBookHandler;
        public BooksController(GetBookByNameHandler getBookByNameHandler,
                               GetAllReadBookHandler getAllReadBookHandler)
        {
            _getBookByNameHandler = getBookByNameHandler;
            _getAllReadBookHandler = getAllReadBookHandler;
        }

        /// <summary>
        /// Search Book by Name
        /// </summary>
        /// <param name="searchBook">SearchBook DTO</param>
        /// <returns></returns>
        [HttpGet("search")]
        public async Task<IActionResult> SearchBook([FromQuery] SearchBookDto searchBook)
        {
            var request = new GetBookByNameRequest()
            {
                BookName = searchBook.BookName,
            };
            return Ok(await _getBookByNameHandler.SearchAsync(request));
        }

        /// <summary>
        /// Get list of books User have completed reading
        /// </summary>
        /// <param name="UserId">Id of User</param>
        /// <returns></returns>
        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetAllCompletedReadBook(
            int UserId)
        {
            var request = new GetAllReadBookRequest()
            {
                UserId = UserId
            };
            return Ok(await _getAllReadBookHandler.GetAllCompletedReadBookAsync(request));
        }
    }
}
