using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_interfaces
{
    internal interface IActionExecuter
    {
        double PerformActions(List<Step> steps);
    }
}
