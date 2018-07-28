using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    class Program
    {
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
        }
    }
}
