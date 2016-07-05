using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace webscape
{
    class Program
    {
        static void Main(string[] args)
        {
            sortByTags();

            
        }
        static void getURL(string URL)
        {
            //File.WriteAllLines(@"C:\tmp\test.txt", lines);

            WebClient client = new WebClient();

            string content = client.DownloadString("https://www.biblegateway.com/passage/?search=Genesis+1&version=NIV");
            File.WriteAllText(@"C:\tmp\WriteText.txt", content);
        }
        static void sortByTags()
        {
            string filename = @"C:\tmp\output";
            string[] lines = System.IO.File.ReadAllLines(@"C:\tmp\WriteText.txt");
            foreach(string line in lines)
            {
                foreach(char a in line)
                {
                    
                    if(a == '>')
                    {
                        File.AppendAllText(filename, "\n");
                    }
                    File.AppendAllText(filename, $"{a}");
                }
            }

        }
        static void reg()
        {
            //string input = new WebClient().DownloadString(@"http://eu.battle.net/wow/en/character/Kazzak/Ierina/simple");
            string input = File.ReadAllText(@"C:\tmp\WriteText.txt");

            //<span id="en-NIV-2" class="text Gen-1-2">
            // Here we call Regex.Match for <span class="equipped">560</span>
            string s = "<span.id=.*en-NIV-.*<.span>";
            //string s = "span.*<.span>";
            //string s = "versenum.*<.span>";
            Match match = Regex.Match(input, s,
                RegexOptions.IgnoreCase);

            // Here we check the Match instance.
            if (match.Success)
            {

                //Console.WriteLine(match.Length);
                //Console.WriteLine(match.NextMatch());
                //Console.WriteLine(match.Value);
                string key = match.Groups[1].Value; //result here
                Console.WriteLine(key);
            }
        }
    }
}
