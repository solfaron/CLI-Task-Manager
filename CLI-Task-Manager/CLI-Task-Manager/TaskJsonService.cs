using System.Text.Json;

namespace CLI_Task_Manager;

public class TaskJsonService
{
    public static void SaveTaskList(List<Task> taskList)
    {
        string json = JsonSerializer.Serialize(taskList);
        File.WriteAllText("tasks.json",json);
    }
    
    public static List<Task> LoadTaskList(List<Task> taskList)
    {
        if (!File.Exists("tasks.json"))
        {
            Console.WriteLine("No tasks file found. Load current tasks list if it exists.");
            return new List<Task>();
        }

        taskList = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(@"tasks.json"));
        return taskList;
    }
}
