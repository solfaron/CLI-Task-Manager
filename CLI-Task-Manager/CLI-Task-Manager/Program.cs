using CLI_Task_Manager;
using Task = CLI_Task_Manager.Task;

class Program
{

    public static void Main(string[] args2)
    {
       CommandRouter.RouteCommand(CommandParser.CheckCommand(args2));
       
    }
}