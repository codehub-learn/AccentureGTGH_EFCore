using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> AuthoredBooks { get; set; } = new();
        public List<Publisher> Publishers { get; set; } = new();
    }
}
