using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();
        }
    }
}







//            try
//            {

//                Console.WriteLine("Pick a number from 100-200");
//                int numberOne = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Pick a second number.");
//                int numberTwo = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Dividing the two...");
//                int numberThree = numberOne / numberTwo;
//                Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree);
//                Console.ReadLine();
//            }
//            catch (FormatException ex)
//            {
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Please don't divide by zero");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.ReadLine();

//            }
//            Console.ReadLine();

//        }
//    }
//}
