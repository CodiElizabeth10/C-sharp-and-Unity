using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class arith
    {
        public void mathh(int One)
        {
            Console.WriteLine(One / 3);
        }

        public static void mathh(int One, out int Solution, int Two = 3)
        {
            Solution = One / Two;
        }

    }
}
