using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__math_od_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathod mathh = new Mathod();

            Console.WriteLine("Lets do some math. Enter a random integer:");
            int randNum = Convert.ToInt32(Console.ReadLine());

            mathh.Add(randNum);
            mathh.Multiply(randNum);
            mathh.Divide(randNum);
            Console.ReadLine();


        }
    }
}
