using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age");
            int number = Convert.ToInt32(Console.ReadLine());
            bool myAge = number == 29;

            do
            {
                switch (number)
                {
                    case 19:
                        Console.WriteLine("You guessed 19. Try Again");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. That's correct!");
                        myAge = true;
                        break;
                    case 33:
                        Console.WriteLine("You Guessed 33. Try Again");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 41:
                        Console.WriteLine("You Guessed 42. lol no");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("You Guessed 21. lol no");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("You Guessed 30. Super warm, hot even, but no");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 95:
                        Console.WriteLine("You Guessed 95. Why would you even guess this one?");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("lol no.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!myAge);

            Console.Read();
            {
            }
        }
    }
}





