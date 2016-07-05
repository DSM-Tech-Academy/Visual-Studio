using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    

    class Program
    {
        

        static void Main(string[] args)
        {
            bill total = new bill();
            while (true)
            {
                string answer = PrintMenu();
               bought item =  PrintProducts(answer);
                //AddItemtoList(item);
                total.addToList($"{item.name}\n");
                
                total.addToBill(item.price);
                Console.Write("Would you like another item? y/n >");
                string more = Console.ReadLine();
                if(more.Contains("n") || more.Contains("N")) { break; }

            }
            print("Thanks for ordering, here is your list of items:");
            Console.Write(total.itemsOnBill);
            Console.WriteLine("Your total bill will be: ${0:.00}", total.total_bill);
        }



        static void print(string line) { Console.WriteLine(line); }
        static string PrintMenu()
        {
            Northwind s = new Northwind();
            var t = from b in s.Categories select b.CategoryName;

            
            print("What Category is the item you would like in? ");
            // Print out the Category choices
            int i = 1;
            foreach (string e in t) { Console.WriteLine($"{i}. {e}"); ++i; }
            Console.Write("> ");
            try
            {
                string answerC = Console.ReadLine();
                if (t.Contains(answerC)) { return(answerC);}
                else
                {
                    print("Please type one of the Categories");
                    PrintMenu();
                    return ("NULL");

                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                print("Please only pick a number");
                PrintMenu();
                return ("NULL");
            }
            
                
            
        }
        static bought PrintProducts(string Cat)
        {
            
            Northwind s = new Northwind();
            var catid = from q in s.Categories
                        where q.CategoryName == Cat
                        select q.CategoryID ;

            int Catid_number = 0;
            foreach (int t in catid) Catid_number = t;
            
            var listOfProducts = from b in s.Products
                    where b.CategoryID == Catid_number
                    select b;
            var listOfProducts2 = from b in s.Products where b.CategoryID == Catid_number select b.ProductName;
            int index = 1;
            foreach (var product in listOfProducts)
            { 
               Console.WriteLine("{0}. {1}\t\t\t ${2:.00}",index, product.ProductName, product.UnitPrice);
               index++;
            }
            print("Please pick the item you would like?");
            string Pickeditem = Console.ReadLine();
            if(listOfProducts2.Contains(Pickeditem))
            {
                decimal price = 0;
                var Lprice = from b in s.Products where b.ProductName == Pickeditem select b.UnitPrice;
                foreach (decimal i in Lprice) price = i;
                bought item = new bought(Pickeditem, price);
                return (item);    
            }
            else
            {
                print("Please type the item you would like to request.");
                PrintProducts(Cat);
                return (new bought(Pickeditem, 0));
                
            }     
        }
        



    }
    class bill
    {
        public decimal total_bill { set; get; }
        public StringBuilder itemsOnBill { set; get; } = new StringBuilder();

        public void addToList(string v)
        {
            itemsOnBill.Append(v);
        }
        public void addToBill(decimal v)
        {
            total_bill += v;
        }
    }
}
