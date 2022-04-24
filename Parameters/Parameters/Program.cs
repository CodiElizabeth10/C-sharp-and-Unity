using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employ<string> employee = new Employ<string>();
            employee.Things.Add("Hello");
            employee.Things.Add("Mars");
            employee.spill();
            Employ<int> employee1 = new Employ<int>();
            employee1.Things.Add(6);
            employee1.Things.Add(7);
            employee1.spill();
            Console.ReadLine();
        }
    }
}
   