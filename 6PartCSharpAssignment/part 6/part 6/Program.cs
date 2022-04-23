using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCandy = new List<string>() {
                "hershey", "hershey", "reeses", "skittles", "reeses", "mms",
                "mms", "airhead", "hershey", "reeses"};

            Console.WriteLine("candy List");
            Console.ReadLine();

            Console.Write("look in ");
          
            for (int i = 5; 0 < i; i--)
            {
                Console.Write(i + " ");
                Console.ReadLine();
            }
            Console.WriteLine();
            HashSet<string> demoSet = new HashSet<string>();
            int lengthBefore, lengthAfter;
            foreach (string candy in myCandy)
            {
                Console.Write(candy);

                lengthBefore = demoSet.Count;
                demoSet.Add(candy);
                lengthAfter = demoSet.Count;


                if (candy.Length <= 6)
                {
                    Console.Write("\\n");
                }
                if (candy.Length > 6 && candy.Length <= 11)
                {
                    Console.Write("\n");
                }

                if (lengthBefore == lengthAfter)
                {
                    Console.Write("\t you chose this already | duplicate\n");
                }

                else
                {
                    Console.Write("\t already purchased | don't buy it twice\n");
                }

                Console.ReadLine();
            }

            Console.WriteLine("\nthank you!");
            Console.ReadLine();
        }
    }
}
       