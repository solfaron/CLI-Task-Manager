namespace CLI_Task_Manager;

public class TaskRepositoryService
{
    public static List<Task> TaskList = new List<Task>();

    public static string AddTask(string desc)
    {
        Status status = Status.Todo;
        DateTime createdAt = DateTime.UtcNow;
        DateTime updatedAt = DateTime.UtcNow;
        
        int id = 1;
        if (TaskList.Count > 0)
        {
            id = TaskList.Max(x => x.Id)+1;
        }
        TaskList.Add(new Task(id, desc, status, createdAt, updatedAt));

        return $"Task successfully added with id:{id}";
    }

    public static string UpdateTask(int id, string desc)
    {
        if(id < 1 || id )
    }
}