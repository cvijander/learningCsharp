﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    // classes have a name, unique within the namespace
    internal class Book
    {
        // classes have instance variables to hold data 
        private string _name;
        private string _author;
        private int _pagecount;


        // classes have one or more constructor
        public Book(string name,string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // TODO: use properies to implement access to our internal data 
        // this is called a property with a "backing field"
        public string Name { 
        get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // TODO: There' s a shorthand way of writing these using the => operator 
         // to create "expression- bodies " properties 
         public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int Pagecount
        {
            get => _pagecount;
            set =>_pagecount = value;
        }





        // TODO: You can omit the get or set if yuou want to prevent 
        // modification or reading the value, or if you want to create 
        // a "computed property" from othe field

        public string Description
        {
            get => $"{Name} by {Author}, {Pagecount} pages";
        }


        // TODO: Properties can be auto-generated -if there's no
        // backing filed, the property can hold the data 

        public string ISBN
        {
            get;set;
        }

        public decimal Price
        {
            get;set;
        }
    }
}
