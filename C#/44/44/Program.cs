using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class number1
    {
        public string name { set; get; }
        public decimal value1 { set; get; }

        public void Number1()
        {
            name = "Number";
            value1 = 2;

        }
        //overloading a method
        public void Number1(string str, decimal num)
        {
            name = str;
            value1 = num;
        }
        static void doNothing()
        {
            Console.WriteLine("Did Nothing");
        }
    }
    class number2 : number1
    {

        public number2(string str, decimal num) : base(str, num) { }
        // Method overriding    
        static void doNothing()
        {
            Console.WriteLine("Did Nothing again");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            // string builder uses a memory block to keep infomation in
            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Oregon");

            Console.WriteLine(sb);
            
            // Each time a string veriable is made it is inmutable and a new string is created in memory everytime it is changed
            string line = "Help";
            Console.WriteLine(line);
            




        }
    }
}
