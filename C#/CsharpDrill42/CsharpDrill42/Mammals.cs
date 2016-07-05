using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDrill42
{
    class Mammals
    {
        public int age { get; set; }
        public string food { get; set; }
        public string size { get; set; }
        private string habitat;
        protected bool mammal = true;
        protected string test { get; set; }


        public Mammals()
        {
            // the use of this is to make sure that it puts these into "this" instance of Mammals
            this.age = 1;
            this.food = "Meat";
            this.size = "small";
            this.habitat = "Land";
        }

        public Mammals(int age, string food, string size)
        {
            this.age = age;
            this.food = food;
            this.size = size;

        }


        public string Habitat
        {
            get { return habitat; }
            set
            {
                string real_habitats = "Sea, Land, water, lake, sky, air, tree, forest, swamp";
                if (real_habitats.Contains(value))
                {
                    habitat = value;
                }
                else
                {
                    Console.WriteLine($"habitat can only be one of the following: \n{real_habitats}");
                    Console.WriteLine("habitat is not set");
                }
            }

        }
        public string Moves()
        {
            return ("Fast like a rabbit or slow like a turrle");
        }

        public void print()
        {
            Console.WriteLine("is a {0} {1} year old mammal that eats {2} and lives in the {3}. ", size, age, food, habitat);
        }


    }
    class Cats : Mammals
    {
        public Cats(int age, string food, string size) : base(age, food, size)
        {
        }

        public string color { get; set; }
        private string habitat;

        public string Habitat
        {
            get { return habitat; }
            set
            {
                string real_habitats = "Land, House, tree, forest, Desert, jungle, Farm, outside, inside";
                if (real_habitats.Contains(value))
                {
                    habitat = value;
                }
                else
                {
                    Console.WriteLine($"habitat can only be one of the following: \n{real_habitats}");
                    Console.WriteLine("habitat is not set");
                }
            }
        }
        public string Moves()
        {
            return ("Jumps for sofa to drapes and Back again");
        }
    }

    class Dogs : Mammals
    {


        public Dogs(int age, string food, string size) : base(age, food, size)
        {
        }
        public void tests()
        {
            if (this.mammal)
            {
                Console.WriteLine("This is true, Dogs are Mammals");
            }
        }

    }
}
