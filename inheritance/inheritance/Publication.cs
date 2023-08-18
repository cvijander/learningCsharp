﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Publication
    {
        private string _name;

        public Publication(string name, int pagecount, decimal price)
        {
            _name = name;
            Pagecount = pagecount;
            Price = price;
        }

        //The PageCount property has no backing field
        public int Pagecount { get; 
            set; }

        public decimal Price { get; set; }

        public string Name { get { return _name;} 
        
            // use the setter to validate the new property value
            set
            {
                if(value =="")
                {
                    throw new ArithmeticException("Name cannot be blank");

                }
                _name = value;
            }
        
        }

        // TODO: use the "virtual " keyword to indicate that a method 
        //can be overridden by subclasses to customize behavior 

        public virtual string GetDescription ()
        {
            return $"{Name} , {Pagecount} pages";
        }


    }
}
