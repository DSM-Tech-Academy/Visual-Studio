using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_shipping
{
    public delegate string MyDelegate(int arg1);

    
    class Program
    {
        static string zone1(int arg1) { return ((arg1 * 1.25).ToString());}        
        static string zone2(int arg1) { return ((arg1 * 1.12 + 25).ToString()); }
        static string zone3(int arg1) { return ((arg1 * 1.08).ToString()); }
        static string zone4(int arg1) { return ((arg1 * 1.04 + 25).ToString()); }
        static void print(string line) { Console.WriteLine(line); }
        static void Main(string[] args)
        {
            string ZoneAnwsers = "zone1, zone2, zone3, zone4";
            string whichZone = "NONE";
            do
            {
                Console.Write("Which Zone is the package going to? ");
                whichZone = Console.ReadLine();

            } while (!ZoneAnwsers.Contains(whichZone));
            switch (whichZone)
            {
                case "zone1":
                    MyDelegate shipping = zone1;
                    break;
                case "zone2":
                    MyDelegate shipping = zone2;
                    break;
                case "zone3":
                    MyDelegate shipping = zone3;
                    break;
                case "zone4":
                    MyDelegate shipping = zone4;
                    break;
                case default:
                    MyDelegate shipping = zone1;
                    break;
            }
            
            Console.Write("How much is your package? ");
            string Stringvalue = Console.ReadLine();
            int value = Stringvalue

        }
    }
}
