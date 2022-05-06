using GoodReads.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReads.Domain.Users
{
    public partial class User
    {
        public User()
        {
            Books = new List<Book>();
        }

        public User(string name)
        {
            this.Update(name);
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
