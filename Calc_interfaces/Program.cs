using Calc_interfaces;

string a = Console.ReadLine();
OrderCreator creator = new OrderCreator();
ActionExecuter ActionExecuter = new ActionExecuter();
Console.WriteLine(ActionExecuter.PerformActions(creator.GetSteps(a)));