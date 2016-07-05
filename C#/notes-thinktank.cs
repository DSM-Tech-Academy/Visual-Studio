using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace think_tank
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            bool canVote = true;
            char grade = 'A';


            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !

            // Calling Gen classes 


            Temperature micTemp = Temperature.Low;

            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 =" + sum(5, 10));


            Console.ReadKey();
        }
        static void NUMBERS()
        {
            // Integer with a max numbere of 2,147,483,647
            int maxInt = int.MaxValue;

            //Long with a max number of 9,223,372,036,854,775,807
            long maxlong = long.MaxValue;

            // Decimal has maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is 32 bit number with a max value of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A double float is a 32 bit munber with a max value of 1.797693134E+308 with 15 decimals of precision
            double maxdouble = double.MaxValue;

            // short hand to start a variable
            var anotherName = "Tom";


            // casting is changing tpyes

            double pi = 3.14;
            int intPi = (int)pi;

            // Math Functions
            // Acos Asin Atan Atan2 Cos Cosh Exp Log Sin Sinh Tan Tanh

            double number1 = 10.5;
            double number2 = 15;

            //Console.WriteLine("Math.Abs(number1)" + (Math.Abs(number1)));
            //Console.WriteLine("Math.Pow(number1, 2)" + (Math.Pow(number1, 2)));
            //Console.WriteLine("Math.Sqrt(number1)" + (Math.Sqrt(number1)));

            // Random numbers
            Random rand = new Random();
            Console.WriteLine("Random number between 1 and 10 " + (rand.Next(1, 11)));


        }
        static void IFandSWITCH()
        {
            int age = 14;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elemetary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            // ! works
            Console.WriteLine("!true " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 17:
                    Console.WriteLine("Help us all");
                    //goto HELP;
                    break;

            }
        }
        static void LOOPS()
        {

            int i = 0;
            while (i < 10)
            {
                if (i == 7)
                {
                    Console.WriteLine("What?");
                    i++;
                    continue;

                }


                Console.WriteLine(i);
                i++;
            }

            // do loops 
            string guess;

            do
            {
                Console.WriteLine("Guess a Number ");
                guess = "15";  // Console.ReadLine();

            } while (!guess.Equals("15"));


            for (int I = 0; I < 10; I++)
            {
                if ((I % 2) > 0)
                {
                    Console.WriteLine(I);
                }
            }

            // foreach loop
            string RandStr = "Here are some ";

            foreach (char C in RandStr)
            {
                Console.WriteLine(C);
            }

        }
        static void STRINGS()
        {
            

            string sampleString = "A Bunch of random words";
            string sampleString2 = "More random words";

            // Trim trims white space off the end
            sampleString = sampleString.Trim();


            Console.WriteLine("Is emty: " + String.IsNullOrEmpty(sampleString));
            Console.WriteLine("Is emty or White space: " + String.IsNullOrWhiteSpace(sampleString));
            Console.WriteLine("Is emty: " + sampleString.Length);
            Console.WriteLine("Index of Bunch " + sampleString.IndexOf("Bunch"));
            Console.WriteLine("2nd word " + sampleString.Substring(2,6));
            Console.WriteLine("Strings Equal " + sampleString.Equals(sampleString2));
            Console.WriteLine("Starts With " + sampleString.StartsWith("A Bunch"));
            Console.WriteLine("Ends With " + sampleString.EndsWith("words"));

            // replacing part of the string
            sampleString = sampleString.Replace("words", "characters");

            // Removes the first 2 characters is (((not inclusive))) 
            sampleString = sampleString.Remove(0, 2);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };

            Console.WriteLine("Name List " + String.Join(",", names));

            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1100);

            Console.WriteLine(fmtStr);




             














        }
        static void STRINGBUILDER()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Oregon");
            //sb.Clear();

            sb.Replace("a", "e");

            sb.Remove(5, 7);
            Console.WriteLine(sb.ToString());









        }
        static void ARRAYS()
        {
            int[] randNum;

            int[] Numarray = new int[5];

            int[] ra2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array length is " + ra2.Length);
            Console.WriteLine("Item 0 " + ra2[0]);

            for (int i = 0; i < ra2.Length; i++)
            {
                Console.WriteLine("line number" + ra2[i]);
            }

            Console.WriteLine("Where is 1 in the Array " + Array.IndexOf(ra2, 1));

            string[] names = { "Tom", "Dave", "Andy" };

            // 2 d arrays

            int[,] multArray = new int[5, 3];

            int[,] multi2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach(int num in multi2)
            {
                Console.WriteLine(num);
            }

            for(int x = 0; x < multi2.GetLength(0); x++)
            {
                for(int y = 0; y < multi2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2} ", x, y, multi2[x, y]);

                }
            }
             





              










             






        }
        static void LISTS()
        {
            List<int> numlist = new List<int>(7);

            numlist.Add(5);
            numlist.Add(15);

            int[] randArray = { 1, 2, 3, 4, 5 };

            numlist.AddRange(randArray);

            List<int> numList2 = new List<int>(randArray);
            Console.WriteLine("4 is in index " + numlist.IndexOf(4));
            Console.WriteLine("5 in List " + numlist.Contains(5));

            List<string> strlist = new List<string>(new string[] { "Tom", "Paul" });

            Console.WriteLine("Tom in List " + strlist.Contains("tom", StringComparer.OrdinalIgnoreCase));





        }
        static void ExceptionHandling()
        {
            try
            {
                Console.Write("Divide 10 by");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));

            }
            catch(DivideByZeroException BOB)
            {
                Console.WriteLine("Can't do that!");
                //Console.WriteLine(BOB);

            }
            catch(Exception BOB)
            {
                Console.WriteLine(BOB.GetType().Name);
                Console.WriteLine(BOB.Message);
            }

        }
        static void CallingClasses()
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            Console.WriteLine($"{spot.name} Says {spot.sound}");
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.toString());

            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                sound = "Grrr"
            };

            Console.WriteLine(grover.weight);

            Dog spike = new Dog();
            spike = new Dog(20, 15, "Spike", "Grr", "Chicken");
            Console.WriteLine(spike.toString());

            Shape rect = new Rectangle(5, 5);
            Console.WriteLine("Rectangles area is: " + rect.area());

            Shape tri = new triangle(4, 3);
            Console.WriteLine("Trianlges area is: " + tri.area());
        }
        static void CallingGen_class()
        {
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";
            superman.showData();

            KeyValue<int, string> Samsung = new KeyValue<int, string>(50, "Big TV");

            Samsung.showData();
        }
    }
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound  { get; set; }
        static int numOfAnimals = 0;

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Sets defaults of the values of Animals when none are given
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name   = "No Name";
            this.sound  = "No Sound";
            numOfAnimals++;
        }
        // Lets the program set all the Attributes of the Animal in one line
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        // Creates a string in a readable format that can be called and printed about each Animal
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }
        
        // Shows how many of this class has been created
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        } 
        // default argruments if none is given
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2; 
        }
    }

    class Dog : Animal
    {
        public string favFood { get; set; }

        //  :base will use the Animal class to set all the ones from it's class
        public Dog() : base()
        {
            this.favFood = "No Faverite";
        }
        // putting in the ablity to set all the options in one line
        public Dog(double height, double weight, string name, string sound, string favFood): base (height, weight, name, sound)
        {
            this.favFood = favFood;
        }
        // Overriding a method that was in the parent class just put the new in front of the same method
        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }

    }

    // Abstract class 
    abstract class Shape
    {
        public abstract double area();

        // Abstract classes can contain methods
        public void sayHi()
        {
            Console.WriteLine("Hello");
       
        }
    }
    // interface
    public interface ShapeItem
    {
        double area();

    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area() { return length * width; }
    }   
    
    class triangle : Shape
    {
        private double theBase;
        private double height;

        public triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }
        public override double area() { return .5*(theBase * height); }

    }
    // Generic classes
    class KeyValue<Tkey, TValue>
    {
        public Tkey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(Tkey k, TValue v)
        {
            key = k;
            value = v;

        }
        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }

    }
    // Keep checking this out for more information
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    delegate double GetSum(double num1, double num2);
}
