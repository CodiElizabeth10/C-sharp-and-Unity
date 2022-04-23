using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>();
                intList.Add(400);
                intList.Add(10);
                intList.Add(12);
                Console.WriteLine("Pick a number to divide by 400");
                intList[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a number to divide by 10");
                intList[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a number to divide by 12");
                intList[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = intList[0] / numberTwo;
                Console.WriteLine(intList[0] + " divided by " + numberTwo + " = " + numberThree);
                int numberFour = intList[1] / numberTwo;
                Console.WriteLine(intList[1] + " divided by " + numberTwo + " = " + numberFour);
                int numberFive = intList[2] / numberTwo;
                Console.WriteLine(intList[2] + " divided by " + numberTwo + " = " + numberFive);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();

            }
            Console.ReadLine();

        }
    }
}