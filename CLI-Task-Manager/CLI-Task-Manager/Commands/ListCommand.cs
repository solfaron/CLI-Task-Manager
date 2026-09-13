namespace CLI_Task_Manager.Commands;

public class ListCommand
{
    public static string ListTasks(Command command)
    {
        List<Task> tasks = TaskJsonService.LoadTaskList();
        
        Status? filter = command.Text switch
        {
            "done" => Status.Done,
            "todo" => Status.Todo,
            "in-progress" => Status.InProgress,
            "" => null,
            _ => throw new ArgumentOutOfRangeException(nameof(command.Text), command.Text, null)
        };

        if (filter != null)
        {
            tasks = tasks.Where(task => task.Status == filter ).ToList();
        }
        
        if (tasks.Count > 0)
        {
            return String.Join(Environment.NewLine, tasks);
        }

        return "None elements in list";
    }
}