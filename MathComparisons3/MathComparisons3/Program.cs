using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonsOperatorsASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            int hoursWeek = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyWage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            int weeklyHours = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Annual salary of Person 1:");
            int product = hourlyRate * hoursWeek * 52;
            Console.WriteLine(product);

            Console.WriteLine("Annual salary of Person 2");
            int product1 = hourlyWage * weeklyHours * 52;
            Console.WriteLine(product1);
            

            int personOne = product;
            int personTwo = product1;

            bool makesMore = personOne > personTwo;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(makesMore);
            Console.ReadLine();

        }
    }
}

