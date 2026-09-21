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
        List<Task> filteredTasks = TaskList;
        
        if (filter != null)
        {
            filteredTasks = TaskList.Where(task => task.Status == filter ).ToList();
        }
        
        return filteredTasks;
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
        Task searchTask = TaskList.FirstOrDefault(x => x.Id == id);
        if (searchTask != null)
        {
            searchTask.Description = desc;
            searchTask.UpdatedAt = DateTime.UtcNow;
            TaskJsonService.SaveTaskList(TaskList);
            return $"Task updated with id:{id}";
        }

        return $"Task with such id not found";
    }

    public static string DeleteTask(int id)
    {
        Task searchTask = TaskList.FirstOrDefault(x => x.Id == id);
        if (searchTask != null)
        {
            TaskList.Remove(searchTask);
            TaskJsonService.SaveTaskList(TaskList);
            return $"Task with id[{id}] successfully deleted!";
        }

        return $"Task with such id not found";
    }
}