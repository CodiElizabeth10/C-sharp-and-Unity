using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(DateTime.Now);
            Console.WriteLine("How long from now would you like to set an alarm for? (enter number for hours)");
            int timespan = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DateTime.Now.AddHours(timespan));

            Console.Read();
        }
}
}