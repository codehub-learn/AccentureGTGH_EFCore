using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public int? Pages { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public List<Genre> Genres { get; set; } = new();
        public Synopsis Synopsis { get; set; } //Reference
    }
}
