using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Genesis
{
    class Program
    {
        static void Main(string[] args)
        {
            try3();
        }
        static void try1()
        {
            //string pattern = @"<span.*>.*<.span>";
            string pattern = @"<span id=.*>";
            Regex rgx = new Regex(pattern);
            string input = File.ReadAllText(@"C:\tmp\sample.txt");
            //string sentence = "Who writes these notes?";

            foreach (Match match in rgx.Matches(input))
            {
                string m = match.Value;
                if (m.Contains("id=\"en-NIV-17\""))
                {
                    Console.WriteLine(m.Length);
                    //Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                    //Console.WriteLine($"{match.Groups} --- {match}");
                }
            }
        }
        static void try2()
        {
            string input = File.ReadAllText(@"C:\tmp\WriteText.txt");

            string pattern = "<.*>";
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {

            }
        }
        static void try3()
        {
            List<string> results = new List<string>();
            string input = File.ReadAllText(@"C:\tmp\WriteText.txt");
            // Finding the verses in the file

            for (int i = 1; i < 31; i++)
            {
                
                int index = input.IndexOf($"id=\"en-NIV-{i}");
                int index2 = input.IndexOf($"id=\"en-NIV-{(i + 1)}");
                int d = index2 - index;
                results.Add(input.Substring(index, d));
                //Console.WriteLine(i);
            }

            // Remove non verse comments from string


            StreamWriter sfile = new System.IO.StreamWriter(@"C:\\tmp\newverse1.txt");
            bool yes = true;
            char one = '<';
            char two = '>';
            foreach (string m in results)
            {
                string s1 = Regex.Replace(m, "[^A-Za-z0-9 _ <>,.\"]", "");
                StringBuilder sb = new StringBuilder();
                yes = true;
                foreach (char a in s1)
                {
                    if (a == one) yes = true;
                    if (a == two) { yes = false; continue; }
                    if (yes) continue;
                    //Console.Write(a);
                    sb.Append(a);

                }
                Console.WriteLine(sb);
                  sfile.WriteLine(sb.ToString());
            }
            sfile.Close();

            
        }
    }
}
