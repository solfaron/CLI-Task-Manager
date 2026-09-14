using CLI_Task_Manager;

class Program
{

    public static void Main(string[] args2)
    {
       CommandRouter.RouteCommand(CommandParser.CheckCommand(args2));
       
    }
}