using Calc_interfaces.Actions;
namespace Calc_interfaces;

public class ActionExecuter : IActionExecuter
{
    private Sum sum = new Sum();
    private Subtraction sub = new Subtraction();
    private Multiplication mul = new Multiplication();
    private Division div = new Division();
    
    public double PerformActions(List<Step> steps)
    {
        double result = 0;
        foreach (var step in steps)
        {
            switch (step.Operation)
            {
                case "+":
                    result = sum.Operation(result, step.Obj);
                    break;
                case "-":
                    result = sub.Operation(result, step.Obj);
                    break;
                case "*":
                    result = mul.Operation(result, step.Obj);
                    break;
                case "/":
                    result = div.Operation(result, step.Obj);
                    break;
            }
        }

        return result;
    }
}