﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public bool Fiction { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
