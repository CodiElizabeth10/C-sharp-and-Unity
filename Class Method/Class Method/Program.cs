using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            arith arithmetic = new arith();
            Console.WriteLine("Type number:");
            int One = Convert.ToInt32(Console.ReadLine());
            arithmetic.mathh(One);
            int answer;
            arith.mathh(4, out answer, 1);
            Console.WriteLine(answer);

            sArith.EasyWay();

            Console.Read();

        }
    }
}
