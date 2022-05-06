using GoodReads.Domain;

namespace GoodReads.Application.UserServices.Commands
{
    public class AddBookRequest
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }
    }
}
