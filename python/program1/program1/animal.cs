using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        // encapsulate fields
        public int Age
        {
            // this is a key word to make sure you are talking about this instance of the class Animal
            get { return this.age; }
            // value is a keyword that picks up the inputted value 
            set {
                if (value < 0)
                {
                    Console.WriteLine("Age can not be negitive");
                }
                else { this.age = value; }
                

            }
        
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }

        }


        public virtual void move()
        {
            Console.Write("Moved");
        }
        public virtual void makeNoise()
        {
            Console.WriteLine("made noise \n");
        }
    }
}
