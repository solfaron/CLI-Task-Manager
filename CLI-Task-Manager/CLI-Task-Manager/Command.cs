namespace CLI_Task_Manager;

public class Command
{
    public string CommandName { get;  set; }
    public int Id { get;  set; }
    public string Text { get;  set; }
    
    public Command()
    {
    }

    public Command(string commandName, string text)
    {
        CommandName = commandName;
        Text = text;
    }
    public Command(string commandName, int id)
    {
        CommandName = commandName;
    }
    public Command(string commandName, int id, string text)
    {
        CommandName = commandName;
        Id = id;
        Text = text;
    }
   
}