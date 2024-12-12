using TaskManagerConsoleApplication.Models;

namespace TaskManagerConsoleApplication.Services;

public class AlertService
{
    public static void GenerateAlertForDueDate(List<Todo> todos)
    {
        var today = DateTime.Today;
        
        var overdueTodos = todos.Where(t => t.DueDate < today).ToList();
        var dueTodayTodos = todos.Where(t => t.DueDate.Date == today).ToList();
        var upcomingTodos = todos.Where(t => t.DueDate > today).ToList();
        
        if (overdueTodos.Any())
        {
            Console.WriteLine("Overdue Todos:");
            foreach (var todo in overdueTodos)
            {
                Console.WriteLine(todo);
            }
        }

        if (dueTodayTodos.Any())
        {
            Console.WriteLine("\nTodos due today:");
            foreach (var todo in dueTodayTodos)
            {
                Console.WriteLine(todo);
            }
        }

        if (upcomingTodos.Any())
        {
            Console.WriteLine("\nUpcoming Todos:");
            foreach (var todo in upcomingTodos)
            {
                Console.WriteLine(todo);
            }
        }
    }
}