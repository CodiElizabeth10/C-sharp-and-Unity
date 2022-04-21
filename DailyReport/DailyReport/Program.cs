using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("TheTechAcademy");
            Console.WriteLine("Daily Report press enter to begin:");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello, " + yourName);
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are on the " + yourCourse + " course.");
            Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You are on page: " + pageNumber);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \'true\' or \'false.\'");
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHour = Console.ReadLine();
            Console.WriteLine("You studied for: " + studyHour + " hours");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day! This is the end of the program, press enter to exit.");
            Console.ReadLine();

        }
    }
}
