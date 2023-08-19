﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tostring
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            PageCount = pages;
        }

        public override string ToString()
        {
            return $"Book: {Name} by {Author}";
        }

        public string ToString(char format)
        {
            if (format == 'B')
                return $"Book: {Name}: {Author}";
            if (format == 'F')
                return $"Book: {Name} by {Author} is {PageCount} pages";
            return ToString();
        }
    }
}
