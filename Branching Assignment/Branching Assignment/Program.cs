using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();


            Console.WriteLine("How much does your package weight?");
            int customerPackage = Convert.ToInt32(Console.ReadLine());

            string result = customerPackage <= 50 ? "Your package is within weight limit." : "Package too heavy to be shipped via Package Express. Have a good day.";

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("what is your package height?");
            int heightPackage = Convert.ToInt32(Console.ReadLine());

            string result0 = heightPackage <= 50 ? "Your package is within height limit." : "Package too big to be shipped via Package Express. Have a good day.";

            Console.WriteLine(result0);
            Console.ReadLine();

            Console.WriteLine("What is the width of your package?");
            int widthPackage = Convert.ToInt32(Console.ReadLine());

            string result1 = widthPackage <= 50 ? "Your package is within width limit." : "Package too big to be shipped via Package Express. Have a good day.";

            Console.WriteLine(result1);
            Console.ReadLine();


            Console.WriteLine("What is the length of your package?");
            int lengthPackage = Convert.ToInt32(Console.ReadLine());

            string result2 = lengthPackage <= 50 ? "Your package is within length limit." : "Package too big to be shipped via Package Express. Have a good day.";

            Console.WriteLine(result2);
            Console.ReadLine();

            int dimensions = heightPackage * widthPackage * lengthPackage;
            int product = customerPackage;
            int total = dimensions * product / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + total);
            Console.ReadLine();

        }


    }
}

