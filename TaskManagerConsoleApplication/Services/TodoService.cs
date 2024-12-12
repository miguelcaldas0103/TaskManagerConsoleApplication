using TaskManagerConsoleApplication.Models;

namespace TaskManagerConsoleApplication.Services;

public class TodoService
{
    private readonly List<Todo> _todos = new();

    public void Add(Todo todo)
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
}