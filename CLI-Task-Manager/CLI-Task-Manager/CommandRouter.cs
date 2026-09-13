using CLI_Task_Manager.Commands;

namespace CLI_Task_Manager;

public class CommandRouter
{
    private static Dictionary<string,Func<Command, string>> CommandDictionary =
        new Dictionary<string,Func<Command, string>>()
        {
            ["list"] = ListCommand.ListTasks,
            
            
        };
    
    public static void RouteCommand(Command command)
    {
        if (CommandDictionary.TryGetValue(command.CommandName, out Func<Command, string> executeMethod))
        {
            try
            {
                string output = executeMethod(command);
                Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
        else
        {
            Console.WriteLine("Command not found");
        }
    }
}