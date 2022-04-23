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
                    Console.WriteLine("Pick a number");
                    int num0 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pick a second number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Dividing the two...");
                    int num2 = num0 / num1;
                    Console.WriteLine(num0 + " / " + num1 + " = " + num2);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Numbers only, please (: " + ex.Message);
                    return;     
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Do not divide by ZERO: " + ex.Message);
                }
                catch (Exception ex)     
                {
                    Console.WriteLine("uhhhh...something went wrong: " + ex.Message);
                }
                finally   
                {
                    Console.Read();
                }

                Console.WriteLine("This will not show up if you do a FormatException because of the return statement");
                Console.Read();
            }
        }
    }

