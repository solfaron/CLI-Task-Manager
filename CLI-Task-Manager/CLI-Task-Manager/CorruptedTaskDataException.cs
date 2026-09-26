namespace CLI_Task_Manager;

public class CorruptedTaskDataException : Exception
{
    public CorruptedTaskDataException(string message) : base(message) { }
}