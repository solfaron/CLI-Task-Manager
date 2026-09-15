namespace CLI_Task_Manager;

public class TaskRepositoryService
{
    public static List<Task> TaskList = GetTaskList();

    public static List<Task> GetTaskList()
    {
        return TaskJsonService.LoadTaskList();    
    }

    public static List<Task> FilterTaskList(Status? filter)
    {
        List<Task> tasks = GetTaskList();
        
        if (filter != null)
        {
            tasks = TaskList.Where(task => task.Status == filter ).ToList();
        }
        
        return tasks;
    }
    
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
        TaskJsonService.SaveTaskList(TaskList);
        
        return $"Task successfully added with id:{id}";
    }

    public static string UpdateTask(int id, string desc)
    {
        
    }
}