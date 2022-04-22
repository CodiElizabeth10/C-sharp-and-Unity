using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 50)
            {
                counter = counter + 2;
                Console.WriteLine("Counter = " + counter);
            }

            Console.WriteLine("Finished while counter example (: ");
            Console.ReadLine();
        }
    }
}
