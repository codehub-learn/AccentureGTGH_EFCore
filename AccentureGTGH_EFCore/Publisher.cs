﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureGTGH_EFCore
{
    public class Publisher
    {
        public int PublisherKey { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<Author> Authors { get; set; } = new();
    }
}
