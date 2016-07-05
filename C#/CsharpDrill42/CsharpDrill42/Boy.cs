using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDrill42
{
    sealed class Boy
    {
        public int age;
        public string name;

        public Boy()
        {
            age = 10;
            name = "Bob";
        }
        public Boy(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
