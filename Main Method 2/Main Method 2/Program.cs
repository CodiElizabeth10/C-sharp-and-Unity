using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type integer one:");
            int Ten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type second integer and press enter:");
            string input = Console.ReadLine();
            if (input != "")
            {
                int Eleven = Convert.ToInt32(input);
                TwoNumbers.TwoNumbersChoose(Ten, Eleven);
            }
            else
            {
                TwoNumbers.TwoNumbersChoose(Ten);
            }
            Console.ReadLine();
        }
    }
}