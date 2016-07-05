using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projecttest
{
    class Program
    {
        //Declare student structure
        struct student

        {
            public string stnumber;

            public string stname;

            public string sex;

            public float quizz1;

            public float quizz2;

            public float assigment;

            public float midterm;

            public float final;

            public float total;


        };

        //main method
        static void Main(string[] args)
        {

            try
            {
                student[] st = new student[20]; //create an array to store only 20 students'records for testing.
                int itemcount = 0;
                //show menu
                displaymenu();
                int yourchoice;
                string confirm;

                do
                {

                    Console.Write("Enter your choice(1-8):");

                    yourchoice = int.Parse(Console.ReadLine());


                    switch (yourchoice)
                    {

                        case 1: add(st, ref itemcount); break;
                        case 2: delete(st, ref itemcount); break;
                        case 3: update(st, itemcount); break;
                        case 4: viewall(st, itemcount); break;
                        case 5: average(st, itemcount); break;
                        case 6: showmax(st, itemcount); break;
                        case 7: showmin(st, itemcount); break;
                        case 8: find(st, itemcount); break;
                        case 9: bubblesort(st, itemcount); break;

                        default: Console.WriteLine("invalid"); break;

                    }



                    Console.Write("Press y or Y to continue:");

                    confirm = Console.ReadLine().ToString();

                } while (confirm == "y" || confirm == "Y");



            }
            catch (FormatException f) { Console.WriteLine("Invalid input"); }


            ///////////////

            Console.ReadLine();

        }


        //Menu contruction

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
        //method add/append a new record
        static void add(student[] st, ref int itemcount)
        {

            Again:
            Console.WriteLine();
            Console.Write("Enter student's ID:");
            st[itemcount].stnumber = Console.ReadLine().ToString();

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
            st[itemcount].quizz1 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's quizz2 score:");
            st[itemcount].quizz2 = float.Parse(Console.ReadLine());


            Console.Write("Enter student's assigment score:");
            st[itemcount].assigment = float.Parse(Console.ReadLine());


            Console.Write("Enter student's mid term score:");
            st[itemcount].midterm = float.Parse(Console.ReadLine());

            Console.Write("Enter student's final score:");
            st[itemcount].final = float.Parse(Console.ReadLine());

            st[itemcount].total = st[itemcount].quizz1 + st[itemcount].quizz2 + st[itemcount].assigment + st[itemcount].midterm + st[itemcount].final;



            ++itemcount;



        }
        //method to search for the location of the target record
        static int search(student[] st, string id, int itemcount)
        {
            int found = -1;
            for (int i = 0; i < itemcount && found == -1; i++)
            {

                if (st[i].stnumber == id) found = i;

                else found = -1;
            }

            return found;

        }
        //method display all students' records
        static void viewall(student[] st, int itemcount)
        {

            int i = 0;

            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8}(column index)", "0", "1", "2", "3", "4", "5", "6", "7", "8");
            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8,-5}", "ID", "NAME", "SEX", "Q1", "Q2", "As", "Mi", "Fi", "TOTAL");

            Console.WriteLine("=====================================================");

            while (i < itemcount)
            {

                if (st[i].stnumber != null)
                {

                    Console.Write("{0,-5}{1,-20}{2,-5}", st[i].stnumber, st[i].stname, st[i].sex);

                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].quizz1, st[i].quizz2, st[i].assigment);

                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].midterm, st[i].final, st[i].total);

                    Console.Write("\n");
                }

                i = i + 1;



            }

        }



        // method to elete record

        static void delete(student[] st, ref int itemcount)
        {
            string id;
            int index;
            if (itemcount > 0)
            {
                Console.Write("Enter student's ID:");
                id = Console.ReadLine();
                index = search(st, id.ToString(), itemcount);

                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1)) //delete the last record
                    {

                        clean(st, index);
                        --itemcount;

                        Console.WriteLine("The record was deleted.");
                    }
                    else //delete the first or middle record
                    {
                        for (int i = index; i < itemcount - 1; i++)
                        {
                            st[i] = st[i + 1];
                            clean(st, itemcount);
                            --itemcount;
                        }

                    }

                }
                else Console.WriteLine("The record doesn't exist.Check the ID and try again.");


            }
            else Console.WriteLine("No record to delete");
        }

        //method ot update record

        static void update(student[] st, int itemcount)
        {
            string id;
            int column_index;
            Console.Write("Enter student's ID:");
            id = Console.ReadLine();
            Console.Write("Which field you want to update(1-7)?:");
            column_index = int.Parse(Console.ReadLine());

            int index = search(st, id.ToString(), itemcount);

            if ((index != -1) && (itemcount != 0))
            {
                if (column_index == 1)
                {
                    Console.Write("Enter student's Name:");

                    st[index].stname = Console.ReadLine().ToString();
                }

                else if (column_index == 2)
                {
                    Console.Write("Enter student's Sex(F or M):");
                    st[index].sex = Console.ReadLine().ToString();
                }
                else if (column_index == 3)
                {
                    Console.Write("Enter student's quizz1 score:");
                    st[index].quizz1 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 4)
                {
                    Console.Write("Enter student's quizz2 score:");
                    st[index].quizz2 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 5)
                {
                    Console.Write("Enter student's assigment score:");
                    st[index].assigment = float.Parse(Console.ReadLine());
                }
                else if (column_index == 6)
                {
                    Console.Write("Enter student's mid term score:");
                    st[index].midterm = float.Parse(Console.ReadLine());
                }
                else if (column_index == 7)
                {
                    Console.Write("Enter student's final score:");
                    st[index].final = float.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Invalid column index");
                st[index].total = st[index].quizz1 + st[index].quizz2 + st[index].assigment + st[index].midterm + st[index].final;


            }
            else Console.WriteLine("The record deosn't exits.Check the ID and try again.");

        }


        //method to calculate average score
        static void average(student[] st, int itemcount)
        {
            string id;
            float avg = 0;
            Console.Write("Enter students'ID:");
            id = Console.ReadLine();
            int index = search(st, id.ToString(), itemcount);
            if (index != -1 && itemcount > 0)
            {
                st[index].total = st[index].quizz1 + st[index].quizz2 + st[index].assigment + st[index].midterm + st[index].final;
                avg = st[index].total / 5;
            }

            Console.WriteLine("The average score is {0}.", avg);
        }
        //method to show max total score 
        static void showmax(student[] st, int itemcount)
        {
            float max = st[0].total;
            int index = 0;
            Console.WriteLine(itemcount);
            if (itemcount >= 2)
            {

                for (int j = 0; j < itemcount - 1; ++j)
                    if (max < st[j + 1].total)
                    {
                        max = st[j + 1].total;
                        index = j + 1;

                    }


            }

            else if (itemcount == 1)
            {
                index = 0;
                max = st[0].total;
            }


            else Console.WriteLine("Not record found!");

            if (index != -1) Console.WriteLine("The student with ID:{0} gets the highest score {1}.", st[index].stnumber, max);


        }
        //method to show min total score
        static void showmin(student[] st, int itemcount)
        {

            float min = st[0].total;
            int index = 0;
            if (itemcount >= 2)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                    if (min > st[j + 1].total)
                    {
                        min = st[j + 1].total;
                        index = j + 1;

                    }



            }

            else if (itemcount == 1)
            {
                index = 0;
                min = st[0].total;
            }
            else Console.WriteLine("No record found!");

            if (index != -1) Console.WriteLine("The student with ID:{0} gets the lowest score {1}.", st[index].stnumber, min);


        }
        //method to find record
        static void find(student[] st, int itemcount)
        {
            string id;
            Console.Write("Enter student's ID:");
            id = Console.ReadLine();

            int index = search(st, id.ToString(), itemcount);
            if (index != -1)
            {
                Console.Write("{0,-5}{1,-20}{2,-5}", st[index].stnumber, st[index].stname, st[index].sex);

                Console.Write("{0,-5}{1,-5}{2,-5}", st[index].quizz1, st[index].quizz2, st[index].assigment);

                Console.Write("{0,-5}{1,-5}{2,-5}", st[index].midterm, st[index].final, st[index].total);
                Console.WriteLine();

            }
            else Console.WriteLine("The record doesn't exits.");

        }


        //method to sort records by total score
        static void bubblesort(student[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j].total < dataset[j - 1].total)
                    {
                        student temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }

        }
        //method to clean deleted record
        static void clean(student[] st, int index)
        {
            st[index].stnumber = null;
            st[index].stname = null;
            st[index].sex = null;
            st[index].quizz1 = 0;
            st[index].quizz2 = 0;
            st[index].assigment = 0;
            st[index].midterm = 0;
            st[index].final = 0;
            st[index].total = 0;

        }


    }
}