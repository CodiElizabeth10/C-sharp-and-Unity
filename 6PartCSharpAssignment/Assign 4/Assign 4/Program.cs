using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assign_4
{

          class Program
        {
            static void Main(string[] args)
            {
                List<string> yourCandy = new List<string>() {
                "hersheys", "reeses", "mrgoodbar",
                "m&ms", "skittles", "gummies",
                "airheads", "twizzlers"};

                bool invalidCandy = true;
                while (invalidCandy)
                {
                    Console.Write("Hello! ... which kind of candy do you want?  ");
                    string candy = Console.ReadLine();
                    int candyPosition = yourCandy.IndexOf(candy);
                if (candyPosition >= 0)
                {
                    invalidCandy = false;
                    Console.WriteLine("Here is your " + candy + " great choice!\n");
                }
                else
                {
                    Console.WriteLine("We don't have " + candy + " sorry! select another type!");
                }
                Console.ReadLine();
            }
        }
        }
    }





