using System.ComponentModel;

namespace CLI_Task_Manager;

public class InputService
{
    public static Command CheckCommand(string[] args2)
    {
        Command returnCommand = new Command();
        
        if (args2.Length == 0 || args2.Length > 3)
        {
            returnCommand.CommandName = "invalid";
            return returnCommand;
        }
        
        string commandName = args2[0];
        int id = 0;
        bool isValid = commandName switch
        {
            "add" => args2.Length == 2,
            "update" => args2.Length == 3 && int.TryParse(args2[1], out id),
            "delete" or "mark-in-progress" or "mark-done" => args2.Length == 2 && int.TryParse(args2[1], out id),
            "list" => args2.Length is 1 or 2,
            _ => false 
        };
        
        if (!isValid)
        {
            returnCommand.CommandName = "invalid";
            return returnCommand;
        }

        string text = commandName switch
        {
            "list" or "add" when args2.Length == 2 => args2[1],
            "update" when args2.Length == 3 => args2[2],
            _ => "" //List with 1 element also goes into this
        };

        returnCommand.CommandName = commandName;
        returnCommand.Id = id;
        returnCommand.Text = text;
        
        return returnCommand;
    }
}