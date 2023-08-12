using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_interfaces.Actions
{
    class Sum : IAction
    {
        public double Operation(double n1, double n2)
        {
            return n1 + n2;
            
        }
    }
}
