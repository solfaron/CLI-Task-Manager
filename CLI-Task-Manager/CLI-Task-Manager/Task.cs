namespace CLI_Task_Manager;

public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public Task(
        int id,
        string description,
        Status status,
        DateTime createdAt,
        DateTime updatedAt)
    {
        Id = id;
        Description = description;
        Status = status;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
}