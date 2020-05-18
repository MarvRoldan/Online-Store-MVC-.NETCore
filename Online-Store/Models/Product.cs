﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Store.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
    }
}
