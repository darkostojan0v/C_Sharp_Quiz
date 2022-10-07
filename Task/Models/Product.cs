﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTask.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public bool Domestic { get; set; }
    }
}
