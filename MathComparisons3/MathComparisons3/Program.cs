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
            int hourlyRate = 15;
            Console.WriteLine(hourlyRate);
            Console.WriteLine("Hours Worked Per Week?");
            int hoursWeek = 40;
            Console.WriteLine(hoursWeek);



            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyWage = 20;
            Console.WriteLine(hourlyWage);
            Console.WriteLine("Hours Worked Per Week?");
            int weeklyHours = 40;
            Console.WriteLine(weeklyHours);



            Console.WriteLine("Annual salary of Person 1:");
            int product = 15 * 2080;
            Console.WriteLine(product);

            Console.WriteLine("Annual salary of Person 2");
            int product1 = 20 * 2080;
            Console.WriteLine(product1);
            

            int personOne = 31200;
            int personTwo = 41600;

            bool makesMore = personOne > personTwo;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(makesMore);
            Console.ReadLine();

        }
    }
}

