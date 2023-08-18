using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesmodifies
{
    // access modifiers control how propertis and methods are accessed 
    class Book
    {
        // TODO: "public" memebers and methods can be accessed by ane other 
        // NOTE: this is *NOT* the right way yo expose internal data 

        public string _name;

        // TODO: "protected" memebers can only be accessed by the class or a 
        // derived class from this one 

        protected string _author;

        // TODO: "private" is the default and can only be accessed by code 
        // within the class itself 

        private int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}";

        }

        public string GetName ()
        {
            return _name;
        }

        public void SetName(string s)
        {
            _name =s;
        }

        public void SetAuthor (string s)
        {
            _author = s;
        }

        public void SetPageCount(int p)
        {
            _pagecount = p;
        }


    }
}
