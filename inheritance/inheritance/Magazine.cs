using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    // TODO: Declare "Magazine" as a subclass of Publication
    internal class Magazine :Publication
    {

        private string _publisher;
        

        // TODO: use the base() keyword to initizalize the base class 

        public Magazine(string name, string publisher, int pagecount, decimal price):base(name,pagecount,price)
        {
            _publisher=publisher;
        }

        public string Publisher
        {
            get=>_publisher;
            set=>_publisher=value;
        }
    }
}
