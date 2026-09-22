namespace CLI_Task_Manager.Commands;

public class MarkCommand
{
    public static string MarkStatus(Command command)
    {
        int id = command.Id;
        Status status = Status.Done;
        if (command.CommandName == "mark-in-progress")
        {
            status = Status.InProgress;
        }
        return TaskRepositoryService.MarkTask(id, status);
    }
}