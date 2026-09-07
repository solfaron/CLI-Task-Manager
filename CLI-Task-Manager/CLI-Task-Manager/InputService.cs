using System.ComponentModel;

namespace CLI_Task_Manager;

public class InputService
{
    private readonly HashSet<string> commandNames = new HashSet<string>()
    {
        "add", "update", "delete",
        "mark-in-progress", "mark-done", "list"
    };
    
    public static Command CheckCommand(string[] args2)
    {
        Command returnCommand = new Command();
        
        if (args2.Length == 0 || args2.Length > 3)
        {
            returnCommand.CommandName = "invalid";
            return returnCommand;
        }
        
        string CommandName = args2[0];
        int id = 0;
        string text = "";
        switch (CommandName)
        {
            case "add":
                if (args2.Length == 2)
                {
                    text = args2[1];
                }
                break;
            case "update":
                if (args2.Length == 3 && int.TryParse(args2[1], out id))
                {
                    text = args2[2];
                }
                break;

            case "delete":
            case "mark-in-progress":
            case "mark-done":
                if (args2.Length == 2 && int.TryParse(args2[1], out id))
                {
                    id = int.Parse(args2[1]);
                }
                break;
            case "list":
                if (args2.Length == 2)
                {
                    text = args2[1];
                }
                break;
            default:
            {
                returnCommand.CommandName = "invalid";
                break;
            }
                
        }
        
        returnCommand.Id = id;
        returnCommand.Text = text;
        
        return returnCommand;
    }
}