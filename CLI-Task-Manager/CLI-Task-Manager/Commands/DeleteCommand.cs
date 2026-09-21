namespace CLI_Task_Manager.Commands;

public class DeleteCommand
{
    public static string DeleteTask(Command command)
    {
        return TaskRepositoryService.DeleteTask(command.Id);
    }
}