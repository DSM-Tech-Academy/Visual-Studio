using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDrill42
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Mammals is my base class, and it shows overloading method");
            print("with the 2 Mammals() methods.");

            Mammals Spot = new Mammals(10, "Dog Food", "large");
            Spot.Habitat = "Land";
            Spot.print();

            print("Cats is my derived class to the Mammals class");
            print("Cats has an example of overriding methods when it overrides the Move method.");

            Cats Mary = new Cats(5, "Fish", "small");
            Mary.Habitat = "House";
            Mary.Moves();


            Dogs John = new Dogs(3, "Meat", "large");
            John.Habitat = "Land";

            John.tests();
            print("John.tests() is an example of a protected method");

            Boy Dude = new Boy(15, "Jonathan");
            print("Boy is sealed class, which means that it will not accept children classes");
            print(Dude.name);

            try
            {
                int test = Dude.age * Mary.age;
                print($"this is Dude * Mary {test}");
            }
            catch(Exception m)
            {
                print("This is a failure!!!! you may not have put the right age for Dude or Mary");
                // Writting to a log file

            }
            finally
            {
                print("There was not a failure, no Execption was given");
            }







           
        }
        static void print(string line) {Console.WriteLine(line);}
    }
}
