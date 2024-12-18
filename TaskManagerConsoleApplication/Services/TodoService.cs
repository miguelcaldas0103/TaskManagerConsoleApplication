using TaskManagerConsoleApplication.Models;

namespace TaskManagerConsoleApplication.Services;

public class TodoService
{
    private readonly List<Todo> _todos = new();

    public void AddTodo(Todo todo)
    {
        _todos.Add(todo);
    }

    public List<Todo> GetTodos()
    {
        return _todos;
    }

    public void Delete(string todoTitle)
    {
        var todoToDelete = _todos.First(t => t.Title == todoTitle);
        _todos.Remove(todoToDelete);
    }

    public void CompleteTodo(string todoTitle)
    {
        var todoToComplete = _todos.FirstOrDefault(t => t.Title == todoTitle);
        todoToComplete.IsCompleted = true;
    }

    public List<Todo> TodosToComplete()
    {
        return _todos.Where(t => t.IsCompleted == false).ToList();
    }

    public List<Todo> ShowHighPriorityTodos()
    {
        return _todos.Where(t => t.IsCompleted == false).ToList();
    }
    public bool DoesTodoExist(string todoTitle)
    {
        return _todos.Any(todo => todo.Title == todoTitle);
    }
}