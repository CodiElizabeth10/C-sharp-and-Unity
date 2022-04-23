using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
        class Program
        {
            static System.Timers.Timer timer1 = new System.Timers.Timer();
            static void Main(string[] args)
            {
                timer1.Interval = 60;
                timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
                timer1.Start();
                Console.WriteLine("Press \'enter\' to quit...");
                while (true) ;
            }
            static private void timer1_Tick(object sender, System.Timers.ElapsedEventArgs e)
            {
               
                Console.WriteLine("hi hi hi hi hi!");
            }
        }
    }
