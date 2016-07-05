using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
           {
               new Person {Firstname = "John", Lastname = "Doe", Age = 25 },
               new Person {Firstname = "Jane", Lastname = "Doe", Age = 26 },
               new Person {Firstname = "John", Lastname = "willaims", Age = 40 },
               new Person {Firstname = "Samantha", Lastname = "willaims", Age = 35 },
               new Person {Firstname = "Bob", Lastname = "Walters", Age = 12 },


           };

            var results = from p in people
                              //where p.Age < 30
                          orderby p.Lastname descending
                          group p by p.Lastname;
                          
            foreach (var item in results)
            {
                Console.WriteLine(item.Key + "-" + item.Count());
                foreach (var e in item)
                {
                    Console.WriteLine("{0}, {1}", e.Lastname, e.Firstname);
                }
            }
        }
        static void simple1()
        {
            var sample = "I enjoy writing uber-software in c#";

            var results = from c in sample.ToLower()
                          where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                          orderby c
                          group c by c;

            foreach (var item in results)
            {
                Console.WriteLine("{0} - {1} ", item.Key, item.Count());
            }
        }
    }

    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname  { get; set; }
        public int    Age       { get; set; }

    }
}
