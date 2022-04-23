using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_with_Integers_and_Division
{
  
namespace TryCatch
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> numList = new List<int> { };

                Console.WriteLine("Let's make a list of 10 numbers");
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                listCreate:
                    int userNum;
                    int listNum = i + 1;
                    Console.Write("enter the " + listNum + " number and add to list:     ");
                    try
                    {

                        userNum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Type a whole number");
                        goto listCreate;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("number too large, please enter a smaller one.");
                        goto listCreate;
                    }
                    numList.Add(userNum);
                }

                Console.WriteLine();
                Console.WriteLine("Let's pick a number and divide each number in the list by!");
                Console.WriteLine();
            listDivide:
                try
                {
                    Console.Write("Enter in a number to divide the list by:     ");
                    int divideNum = Convert.ToInt32(Console.ReadLine());
                    if (divideNum == 0)
                    {
                        Console.WriteLine("We can't divide by 0. Please choose a number greater than 0");
                        goto listDivide;
                    }
                    for (int i = 0; i < numList.Count; i++)
                    {
                        double results = (double)numList[i] / divideNum;
                        Console.Write(numList[i] + " divided by " + divideNum + " = ");
                        Console.WriteLine(results);
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a whole number");
                    goto listDivide;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number entered too large, please choose a smaller number.");
                    goto listDivide;
                }
                Console.ReadLine();
            }
        }
    }
}
 
