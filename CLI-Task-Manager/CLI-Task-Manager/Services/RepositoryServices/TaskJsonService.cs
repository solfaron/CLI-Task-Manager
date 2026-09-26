using System.Text.Json;

namespace CLI_Task_Manager;

public class TaskJsonService
{
    public static void SaveTaskList(List<Task> taskList)
    {
        string json = JsonSerializer.Serialize(taskList);
        File.WriteAllText("tasks.json",json);
    }

    public static List<Task> LoadTaskList()
    {
        var taskList = new List<Task>();

        if (!File.Exists("tasks.json"))
        {
            return taskList;
        }

        try
        {
            taskList = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(@"tasks.json"));
        }
        catch (JsonException)
        {
            throw new CorruptedTaskDataException("Corrupted task data: incorrect data in file");
        }

        if (taskList == null)
        {
            throw new CorruptedTaskDataException("Corrupted task data: null in file. Are you serious?");    
        }

        List<Task> list = taskList.Where(x => x.Description == null || x.CreatedAt == default).ToList();
        
        if (list.Count != 0)
        {
            throw new CorruptedTaskDataException("Corrupted task data: incorrect data in file");
        }
        
        return taskList;
    }
}
