namespace CLI_Task_Manager.Commands;

public class UpdateCommand
{
    public static string UpdateTask(Command command)
    {
        return TaskRepositoryService.UpdateTask(command.Id, command.Text);
    }
}