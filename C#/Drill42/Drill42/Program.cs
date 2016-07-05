using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill42
{
    // Creation of a delegate
    public delegate void sayYes(string value);
    class Program
    {
        static void Main(string[] args)
        {

            // Here the use of a delegate
            sayYes a = (line) => Console.WriteLine($"what For? {line}");
            a("Thank You");

            // Sealed Class and private modifier
            Customers John = new Customers();
            John.name = "Johnson";
            John.Balance = 150;
            string we = "Hello";
            John.changeType(ref we);
            Console.WriteLine(we);





        }
       
    }
    
    interface IprintConfig
    {
        void Printconfig();


    }

    class Suppliers : IprintConfig
    {
        public string company;
        public string type;
        internal decimal debt;
        private string reputation;
        protected string x = "For Nothing";


        public string Reputation
        {
            set
            {
                string test = "Perfect, Awsome, Okay, Normal, Questionable, Unreliable, Bad, Ugly";
                if (test.Contains(value))
                {
                    reputation = value;
                }
                else
                {
                    Console.WriteLine("Not a proper discription. Please use one of the following: {0}", test);
                }
            }

            get { return reputation; }
        }


        public void Printconfig()
        {
            // Example of this
            Console.WriteLine("{0} is {1} type with {2} reputation and we owe them {3}", this.company, this.type, this.debt, this.reputation);
        }
    }
    // Derived class 
    class contractors : Suppliers
    {
        string suppliersConnection;
    }
    // Sealed class
    sealed class Customers
    {
        public string name { set; get; }
        public string type { set; get; }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value;}
        } 
        public void changeType(ref string vr1)
        {
            // Passing by ref will change the value
            vr1 = "NEW";
        }
    }
 

}

