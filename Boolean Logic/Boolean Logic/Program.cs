using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string yourDuis = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int applicantAge = 18;
            bool applicantDui = false;
            int applicantTickets = 3;

            bool isQualified = (applicantAge >= 18 && !applicantDui && applicantTickets <= 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();



        }
    }
    }
}
