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
            Console.WriteLine("Have you ever had a DUI? Please answer true/false.");
            bool yourDuis = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            bool isQualified = (yourAge >= 18 && !yourDuis && yourTickets <= 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();



        }
    }
    }

