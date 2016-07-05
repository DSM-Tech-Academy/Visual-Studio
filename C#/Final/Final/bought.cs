using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class bought
    {
        public string name     { set; get; }
        public decimal price   { set; get; }
        
        public bought(string n, decimal p)
        {
            name = n;
            price = p;
        }
    }
}
