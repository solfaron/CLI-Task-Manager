using CLI_Task_Manager.Commands;

namespace CLI_Task_Manager;

public class CommandRouter
{
    private static Dictionary<string,Func<Command, string>> CommandDictionary =
        new Dictionary<string,Func<Command, string>>()
        {
            ["list"] = ListCommand.ListTasks,
            ["delete"] = DeleteCommand.DeleteTask,
            ["update"] = UpdateCommand.UpdateTask,
            ["add"] = AddCommand.AddTask,
            ["mark-in-progress"] = MarkCommand.MarkStatus,
            ["mark-done"] = MarkCommand.MarkStatus
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