using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets
{
    public class Pets
    {
        public int age { get; set; }
        public string name { get; set; }
        private string speed;

        public void Howfast()
        {
            Console.Write($"How Fast is {name} ?");
             this.speed = Console.ReadLine();

        }

        public void OutPut()
        {
            Console.WriteLine("This is where we see the final output");
        }
  
    }

    internal class Dog : Pets
    {
        public new void OutPut()
        {
            // This is hiding the OutPut() in Pets
            if (this.age < 7)
            {
                Console.WriteLine("{0} runs {1} through the Neighborhood Like a Boss", name, speed);
            }
        }
    }

}
