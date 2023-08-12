using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc_interfaces
{
    public class OrderCreator : IOrderCreator
    {
        public List<string> operations = new List<string>() {"+", "-", "/", "*", "//", "%" };

        public List<Step> GetSteps(string source)
        {
            Regex regex = new Regex(@"\D*\d+");
            Regex digitRegex = new Regex(@"\d+");

            MatchCollection matches = regex.Matches(source);
            List<Step> steps = new List<Step>();
            foreach (Match match in matches)
            {
                string operation = "+";
                if (operations.Contains(match.Value[0].ToString()))
                {
                    operation = match.Value[0].ToString();
                }
                int obj = int.Parse(digitRegex.Match(match.Value).Value);
                steps.Add(new Step() { Operation = operation, Obj = obj });

            }
            return steps;
        }
    }
}
