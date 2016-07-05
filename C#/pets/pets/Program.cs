using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Welcome to all about Pets!");
            Console.Write("what is the name of your favorite pet? ");
            string name = InputString();
            string TYPEOFPETS = "Dog, Cat, Horse, Cow, pig, Hamster, snake, goat";
            string WhatKind;
            do
            {
                Console.Write($"Great, what kind of pet is {name}? ({TYPEOFPETS}) ");
                WhatKind = InputString();

            } while (!TYPEOFPETS.Contains(WhatKind));
            Console.Write($"How old is {name}? ");
            int Age = 0;
            Age = InputInt();

            

            
           
        }
        static void print(string line) { Console.WriteLine(line); }
        static int InputInt()
        {
            int RETURN = 0;
            try
            {
                RETURN = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception ex)
            {
                print("Please just enter a number. ie 1, 2, 100");
                InputInt();
            }
            return (RETURN);

        }
        static string InputString()
        {
            string STRING = "";
            try
            {
                STRING = Console.ReadLine();
            }
            catch
            {
                print("Please enter only letters, thank you.");
                InputString();
            }
            return (STRING);
        }
    }
}
