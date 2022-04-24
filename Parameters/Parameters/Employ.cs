using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Employ<Data>
    {
        public List<Data> Things = new List<Data> { };

        public void spill()
        {
            foreach (Data thing in Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}


