using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities ctx = new NorthwindEntities())
            {
                var categories = from c in ctx.Categories
                                 orderby c.CategoryName
                                 select c;
                
                foreach (var item in categories)
                {
                    Console.WriteLine(item.CategoryName);
                    foreach(var t in item.Products)
                    {
                        t.UnitPrice++;
                        Console.WriteLine("\t{0} {1:c}", t.ProductName, t.UnitPrice);
                    }
                }
                ctx.SaveChanges();
            }
        }
    }
}
