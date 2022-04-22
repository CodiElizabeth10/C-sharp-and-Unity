using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("May");
            intList.Add("June");
            intList.Add("July");
            intList.Add("August");
            Console.WriteLine("Please enter an index from 0 to 3:");
            int userIndex = Convert.ToInt32(Console.ReadLine());
            if (userIndex >= 0 && userIndex <= 3)
            {
                Console.WriteLine(intList[userIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, invalid index has been entered.");
            }
            Console.ReadLine();



            //ARRAY OF INTEGERS
            //int[] intArray = { 100, 200, 300, 400 };
            //Console.WriteLine("Please enter an index from 0 to 3:");
            //int userIndex = Convert.ToInt32(Console.ReadLine());
            //if (userIndex >= 0 && userIndex <= 3)
            //{
            //    Console.WriteLine(intArray[userIndex]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, invalid index has been entered.");
            //}
            //Console.ReadLine();


            ////ONE DIMENSIONAL ARRAY OF STRINGS
            //string[] strArray = { "Fox", "Bear", "Dolphin", "Wolf" };
            //Console.WriteLine("Please enter an index from 0 to 3:");
            //int userIndex = Convert.ToInt32(Console.ReadLine());
            //if (userIndex >= 0 && userIndex <= 3)
            //{
            //    Console.WriteLine(strArray[userIndex]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, invalid index has been entered.");
            //}
            //Console.ReadLine();
        }
    }
}





