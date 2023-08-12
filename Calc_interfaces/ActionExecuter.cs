namespace Calc_interfaces;

public class ActionExecuter : IActionExecuter
{
    private Sum sum = new Sum();
    private Subtract sub = new Subtract();
    private Multiplication mul = new Multiplication();
    private Divsion div = new Divsion();
    
    public double PerformActions(List<Step> steps)
    {
        double result = 0;
        foreach (var step in steps)
        {
            switch (step.Operation)
            {
                case "+":
                    sum.Operation(result, step.Obj);
                    break;
                case "-":
                    sub.Operation(result, step.Obj);
                    break;
                case "*":
                    mul.Operation(result, step.Obj);
                    break;
                case "/":
                    div.Operation(result, step.Obj);
                    break;
            }
        }

        return result;
    }
}