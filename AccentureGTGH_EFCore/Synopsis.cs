using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class Synopsis
    {
        public int Id { get; set; }
        public string WriterFirstName { get; set; }
        public string WriterLastName { get; set; } 
        public int BookId { get; set; } //Synopsis will reference Book in db
    }
}
