using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        //EXAMPLES OF WAYS YOU CAN WRITE ARRAYS 
        static void Main()
        {
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Codi");
            intList.Remove("Codi");
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            byte[5000] byteArray = new byte[5000];

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 300, 90, 95, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 500, 50000 };

            //numArray2[5] = 650;


            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
