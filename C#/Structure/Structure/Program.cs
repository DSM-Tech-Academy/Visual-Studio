using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct student
    {
        public string stnumber;
        public string stname;
        public string sex;
        public float quiz1;
        public float quiz2;
        public float assigment;
        public float midterm;
        public float final;
        public float total;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void displaymenu()
        {

            Console.WriteLine("=====================================================");

            Console.WriteLine(" MENU ");

            Console.WriteLine("=====================================================");

            Console.WriteLine(" 1.Add student records");
            Console.WriteLine(" 2.Delete student records");
            Console.WriteLine(" 3.Update student records");
            Console.WriteLine(" 4.View all student records");
            Console.WriteLine(" 5.Calculate an average of a selected student's scores");
            Console.WriteLine(" 6.Show student who get the max total score");
            Console.WriteLine(" 7.Show student who get the min total score");
            Console.WriteLine(" 8.Find a student by ID");
            Console.WriteLine(" 9.Sort students by TOTAL");



        }
        ///sequential search
        static int seqsearch(int[] dataset, int target, int n)
        {
            int found = 0;
            int i;
            int pos = -1;
            for (i = 0; i < n && found != 1; i++)
                if (target == dataset[i]) { pos = i; found = 1; }

            return pos;
        }
    

        //method add/append a new record
        static void add(student[] st, ref int itemcount)
        {

            Again:
            Console.WriteLine();
            Console.Write("Enter student's ID:");
            st[itemcount].stnumber = Console.ReadLine().ToString();
            //making sure the record to be added doesn't already exist
            if (search(st, st[itemcount].stnumber, itemcount) != -1)
            {

                Console.WriteLine("This ID already exists.");
                goto Again;

            }


            Console.Write("Enter student's Name:");

            st[itemcount].stname = Console.ReadLine().ToString();


            Console.Write("Enter student's Sex(F or M):");
            st[itemcount].sex = Console.ReadLine().ToString();


            Console.Write("Enter student's quizz1 score:");
            st[itemcount].quiz1 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's quizz2 score:");
            st[itemcount].quiz2 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's assigment score:");
            st[itemcount].assigment = float.Parse(Console.ReadLine());


            Console.Write("Enter student's mid term score:");
            st[itemcount].midterm = float.Parse(Console.ReadLine());

            Console.Write("Enter student's final score:");
            st[itemcount].final = float.Parse(Console.ReadLine());

            st[itemcount].total = st[itemcount].quiz1 + st[itemcount].quiz2 + st[itemcount].assigment + st[itemcount].midterm + st[itemcount].final;



            ++itemcount; //increase the number of items by one



        }
    }

}
