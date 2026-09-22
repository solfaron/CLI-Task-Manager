using CLI_Task_Manager;

class Program
{
    public static void Main(string[] args2)
    {
        if (args2.Length == 0)
        {
            Console.WriteLine("Please enter the command you want to run:");
            Console.WriteLine("add [task name]");
            Console.WriteLine("update [id] [task name]");
            Console.WriteLine("delete [id]");
            Console.WriteLine("list [task status/none]");
            Console.WriteLine("mark-[in-progress/done]");
            return;
        }
        CommandRouter.RouteCommand(CommandParser.CheckCommand(args2));
    }
}