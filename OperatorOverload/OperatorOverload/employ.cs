using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class employ
    {
        public int ID;

        public static bool operator ==(employ employee0, employ employee1)
        {
            return (employee0.ID == employee1.ID);
        }
        public static bool operator !=(employ employee0, employ employee1)
        {
            return (employee0.ID != employee1.ID);
        }
  
        }
    }

