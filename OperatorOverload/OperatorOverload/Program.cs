using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            employ employee0 = new employ { ID = 00 };
            employ employee1 = new employ { ID = 01 };
            employ employee2 = new employ { ID = 00 };
           

            Console.WriteLine(employee0 == employee1);
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee0 == employee2);

            Console.ReadLine();
        }

    }
}