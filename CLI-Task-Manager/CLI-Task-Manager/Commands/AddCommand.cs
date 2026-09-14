namespace CLI_Task_Manager.Commands;

public class AddCommand
{
    public static string AddTask(Command command)
    {
        string desc = command.Text;
        return TaskRepositoryService.AddTask(desc);
    }
}