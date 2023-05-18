using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L11_ICompareable
{
    internal class Door : IOpen
    {

        public string Open()
        {
            return GetType().Name + " is open";
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Open()}";
        }
    }
}
