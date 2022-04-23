using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCandy = new List<string>() {
                "hershey", "hershey", "reeses",
                "mms", "mms", "reeses",
                "airheads", "reeses", "skittles" };

            bool wrongCandy;
            wrongCandy = true;
            while (wrongCandy)
            {


                Console.Write("look for your favorite candy!");
                string candy = Console.ReadLine();

                List<int> candyIndices = new List<int>();
                int currentIndex = 0;
                int candyPosition;
                do
                {
                    candyPosition = myCandy.IndexOf(candy, currentIndex);
                    if (candyPosition >= 0)
                    {
                        currentIndex = candyPosition;
                        candyIndices.Add(currentIndex);
                        currentIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);

                if (candyIndices.Count > 0)
                {
                    wrongCandy = false;
                    Console.Write("That candy isn't available ");

                    if (candyIndices.Count >= 2)
                    {
                        for (int i = 0; i < candyIndices; i++)
                        {
                            if (i == candyIndices.Count - 1)
                            {
                                Console.Write("and " + candyIndices[i]);
                            }
                            else if (i == candyIndices.Count - 2)
                            {
                                Console.Write(candyIndices) + " ");
                    }
                    else
                    {
                        Console.Write(candyIndices[i] + ", ");
                    }
                }

                else
                {
                    Console.Write(candyIndices[0]);
                }

                Console.WriteLine(" is on the list\n");



            else
                {
                    Console.WriteLine("There is no candy here called " + candy);
                }
                Console.ReadLine();

            }
        }
    }
}


