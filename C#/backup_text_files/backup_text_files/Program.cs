using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace backup_text_files
{


    class file_info
    {
        public string name { set; get; }
        public string directory = @"C:\tmp\newFile\";
        public string NameDir { set; get; }
        public string BackupD = @"C:\tmp\Backup\";
        public double old { set; get; }


        public void File_info(string n, string nd)
        {
            name = n;
            NameDir = nd;
           
        }
        public void GetAge()
        {
            double made_time = 0;
            FileInfo info = new FileInfo(this.NameDir);
            var time = info.LastWriteTime;
            made_time += (time.DayOfYear * 24);
            string i = time.Date.ToString();
            if (i.Contains("PM") && !(time.Hour.ToString() == "12")) made_time += 12;
            made_time += time.Hour;
            // Check Time Now
            double Now_time = new double();
            Now_time += (DateTime.Now.DayOfYear * 24);
            string ia = DateTime.Now.ToString();
            if (ia.Contains("PM") && !(DateTime.Now.Hour.ToString() == "12")) Now_time += 12;
            Now_time += DateTime.Now.Hour;
            this.old = Now_time - made_time;
           
        }
        public void moveFile()
        {
            string destfile = BackupD + name;
            Console.WriteLine($"{name} is {old} hours old");
            if (old < 24)
            {
                if (File.Exists(destfile)) File.Delete(destfile);
                // Move the file.
                File.Move(NameDir, destfile);
                Console.WriteLine("{0} was moved to {1}.", NameDir, destfile);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Setup of Directories for checking and sending
            string SourceDirectory =  @"C:\tmp\newFile\";

            // Check for the files in Source Folder
            string[] Files = Directory.GetFiles(@SourceDirectory);
            Console.WriteLine(SourceDirectory);
            Console.WriteLine("--- Files: ---");
            // Gats File names
            string names = Path.GetFileName(SourceDirectory);
            // Go through each file in the Source folder and check age
            foreach (string name in Files)
            {
                file_info f = new file_info();
                f.name = Path.GetFileName(name);
                f.NameDir = name;
                f.GetAge();
                f.moveFile();
                Console.WriteLine("----------------------------------------");
            }
 


      
           


        }
       
        static double GetTime(string fname)
        {
            double made_time = 0;

            FileInfo info = new FileInfo(fname);
            var time = info.LastWriteTime;
            made_time += (time.DayOfYear* 24);
            string i = time.Date.ToString(); 
            if (i.Contains("PM") && !(time.Hour.ToString() == "12")) made_time += 12;
            made_time += time.Hour;
            return (made_time);

            
            
        }
        static void MoveFile(string fname, string Dest)
        {


   
        }
        static double TimeNow()
        {
            double Now_time = new double();
            Now_time += (DateTime.Now.DayOfYear * 24);
            string i = DateTime.Now.ToString();
            if (i.Contains("PM") && !(DateTime.Now.Hour.ToString() == "12")) Now_time += 12;
            Now_time += DateTime.Now.Hour;

            return (Now_time);
        }
    }
}
