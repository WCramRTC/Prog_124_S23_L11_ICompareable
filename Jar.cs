using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L11_ICompareable
{
    internal class Jar : IOpen
    {
        public string Open() // Return window is open
        {
            return GetType().Name + " is open";
        }

        public override string ToString()
        {
            return Open(); // Calls open which returns Window is open
        }
    }
}
