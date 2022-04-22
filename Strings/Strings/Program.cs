using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Codi";
            //string quote = "The man said, \\Hello\" \n hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Codif";

            //bool trueOrfalse = name.Contains("i");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Codi";
            //name = "Elizabeth";

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Codi");
            Console.WriteLine(sb);
            Console.ReadLine();
        }


    }
}

