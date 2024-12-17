using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class AuthorPublisher
    {
        public int AuthorId { get; set;}
        public int PublisherPublisherKey { get; set; } //Name of Class + Name of key property
        public DateTime StartDate { get; set; } = DateTime.Now;

    }
}
