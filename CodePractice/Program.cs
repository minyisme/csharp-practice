using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    class Program
    {
        // enumerations used for switch later
        public enum MonthsOfYear { January=1, February=2, March=3, April=4, May=5, June=6 };

        static void Main(string[] args)
        {

            // variables practice
            Console.WriteLine("Hello World");
            Console.ReadKey();

            int score;
            score = 10;

            int theMeaningOfLife = 42;

            int a = 3;
            int b = 5;

            b = a;
            a = 23;

            // math and user input practice
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

            Console.WriteLine("Choose a radius.");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a height.");
            int h = Convert.ToInt32(Console.ReadLine());

            float pi = 3.1415926f;

            float volumeOfCylinder = pi * r * r * h;
            float surfaceAreaOfCylinder = 2 * pi * r * (r + h);

            Console.WriteLine("The volume of the cylinder is " + volumeOfCylinder + " and the surface area is " + surfaceAreaOfCylinder);
            Console.ReadKey();

            // conditionals practice

            Console.WriteLine("Hello, welcome to Odd or Even");
            Console.WriteLine("Choose a number between 0 and 100");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }
            Console.ReadKey();

            //while loops practice: fizzbuzz

            int fbnum = 0;
            while (fbnum <= 100)
            {
                if (fbnum % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fbnum % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (fbnum % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(fbnum);
                }
                fbnum++;
            }
            Console.ReadKey();

            // arrays and foreach loops

            string[] letters = new string[6] { "a", "b", "c", "d", "e", "f" };
            foreach (string letter in letters)
            {
                Console.WriteLine($"The letter is now {letter}.");
            }

            letters[3] = "g";
            foreach (string l in letters)
            {
                Console.WriteLine($"The letter is now {l}.");
            }
            Console.ReadKey();

            // enumeration and switch

            Console.WriteLine("Which month?");
            int today = Convert.ToInt32(Console.ReadLine());
            switch (today)
            {
                case 1:
                    Console.WriteLine("It's January");
                    break;
                case 2:
                    Console.WriteLine("It's February");
                    break;
                case 3:
                    Console.WriteLine("It's March");
                    break;
                case 4:
                    Console.WriteLine("It's April");
                    break;
                case 5:
                    Console.WriteLine("It's May");
                    break;
                case 6:
                    Console.WriteLine("It's June");
                    break;
                default:
                    Console.WriteLine("Not a valid month");
                    break;
            }
            Console.ReadKey();
        }
    }       
}
