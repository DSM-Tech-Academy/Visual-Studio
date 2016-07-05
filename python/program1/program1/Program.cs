using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling a function with a return value, the type must be the same value as the returning one
            //string word = Concatenate1("Big ", "Job");
            //Console.WriteLine(Concatenate1("Big ", "Job"));

            #region Class calling
            // Class got created and this is how to call it.
            //Animal dog = new Animal();
            //dog.Age = 12;
            // doug is an inhertited class
            //doug Bob = new doug();
            //Bob.Age = 5;
            //Bob.move();
            //Bob.makeNoise();
            //Car john = new Car();
            //john.color = "Blue";
            //john.Drive();
            //john.Stopping();
            //Console.WriteLine("car's color is " + john.color);



            #endregion

            #region Structor

           
            

            #endregion





            // Wait for user to acknowledge the results Keeping the console alive until we hit enter.
            // Console.WriteLine("Press Enter to terminate ...");
            Console.Read();
        }

        struct Address
        {
            // Calling the struct is:
            // Address Customer;
            // customer.Zip = "94062"
            public string Street, City, State, Zip;
        }

        // Create a non-returning function
        static void Concatenate(string first, string last)
        {
            string whole = first + last;
            Console.WriteLine(whole);
        }
        // Creating a returning function

        static string Concatenate1(string first, string last)
        {
            string whole = first + last;
            return (whole);
        }
        // Getting input and printing to screen
        static void askingForName()
        {
            // Writting to the console
            Console.WriteLine("Enter your name, please:");
            // Now read the name entered
            string name = Console.ReadLine();
            // Greet the user with his name
            Console.WriteLine("Hello, " + name);
        }

        static void forLoops()
        {
            // Init the var ; make the condition; increment; 
            for (int see = 0; see < 11; see++)
            {
                Console.WriteLine(see);
            }


        }

        // Challange : Add 2 numbers and print sum
        static void summingTwoNumbers(int first, int second)
        {
            //int sum = first + second;
            //Console.WriteLine(sum);
            Console.WriteLine(first + second);
        }

        // Try and error handling
        static void tryAndError()
        {
            string errorMessage;
            int numerator;
            int denominator;
            int result;

            Console.WriteLine("Enter the numerator");
            numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter the denominator");
            denominator = Int32.Parse(Console.ReadLine());

            try
            {
                result = numerator / denominator;

                Console.WriteLine();
                Console.WriteLine("The result is: " + result);
            }

            catch (OverflowException ofEx)
            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch (DivideByZeroException dEx)
            {
                errorMessage = dEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }
        }





    }
}
