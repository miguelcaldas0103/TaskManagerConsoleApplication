namespace TaskManagerConsoleApplication.Models;

public enum Priority { Low, Medium, High, VeryHigh }

public class Todo
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public bool IsCompleted { get; set; }
}