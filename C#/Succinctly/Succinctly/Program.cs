using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Succinctly
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Customer> customers =
             from cust in Company.Customers
             select cust;
            foreach (Customer cust in customers)
                Console.WriteLine(cust.Name);
            var customers3 =
                from cust3 in Company.Customers
                select new
                {
                    Name = cust3.Name
                };
            foreach (var cust3 in customers3)
                Console.WriteLine(cust3.Name);
            var customers4 =
                from cust4 in Company.Customers
                where cust4.Name.Length > 3 && !cust4.Name.StartsWith("G")
                select cust4;
            foreach (var cust4 in customers4)
            Console.WriteLine("Dude: {0}", cust4.Name);
            var customers5 =
            from cust5 in Company.Customers
            orderby cust5.Name descending
            select cust5;
            foreach (var cust5 in customers5)
                Console.WriteLine(cust5.Name);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Order
    {
        public int CustomerID { get; set; }
        public string Description { get; set; }
    }
    public static class Company
    {
        public static List<Customer> Customers { get; set; }
        public static List<Order> Orders { get; set; }
        static Company()
        {

            Customers = new List<Customer>
            {
                new Customer { ID = 0, Name = "May" },
                new Customer { ID = 1, Name = "Gary" },
                new Customer { ID = 2, Name = "Jennifer" }
            };
            Orders = new List<Order>
            {
             new Order { CustomerID = 0, Description = "Shoes" },
             new Order { CustomerID = 0, Description = "Purse" },
             new Order { CustomerID = 2, Description = "Headphones" }
            };
        }

    }

    }
