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

    public void Delete(Todo todo)
    {
        _todos.Remove(todo);
    }

    public void CompleteTodo(Todo todo)
    {
        todo.IsCompleted = true;
    }

    public List<Todo> TodosToComplete()
    {
        return _todos.Where(t => t.IsCompleted == false).ToList();
    }

    public List<Todo> ShowHighPriorityTodos()
    {
        return _todos.Where(t => t.IsCompleted == false).ToList();
    }
}