using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    // doug is inheritance of Animal
    class doug : Animal
    {
        public string name;
        public string owner;


        public override void move()
        {
            Console.WriteLine("running");
            
        }
       
    }
}
