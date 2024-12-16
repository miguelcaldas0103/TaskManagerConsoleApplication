using TaskManagerConsoleApplication.Models;
using TaskManagerConsoleApplication.Services;

Console.WriteLine("Welcome to TaskManagerConsoleApplication!");

var todoService = new TodoService();

while (true)
{
    Console.WriteLine("1. Add new todo.");
    Console.WriteLine("2. Get list of todos.");
    Console.WriteLine("3. Remove todo from list.");
    Console.WriteLine("4. Mark todo as completed.");
    Console.WriteLine("5. Show list of todos to complete.");
    Console.WriteLine("7. Show high priority todos.");
    Console.WriteLine("6. Generate todo alert calendar.");
    Console.WriteLine("q. Quit application.");
    
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter todo title: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter todo description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter todo duedate: ");
            var duedate = Console.ReadLine();
            if (!DateTime.TryParse(duedate, out DateTime dueDate))
            {
                Console.WriteLine("Please enter a valide date for the duedate.");
                break;
            }
            Console.WriteLine("Enter todo priority (Low, Medium , High, Very High: ");
            var priority = Console.ReadLine();
            if (priority != "Low" && priority != "Medium" && priority != "High" && priority != "Very High")
            {
                Console.WriteLine("Please enter a valid priority.");
                continue;
            }
            todoService.AddTodo(new Todo()
            {
                Title = title,
                Description = description,
                DueDate = DateTime.Parse(duedate),
                Priority = Enum.Parse<Priority>(priority)
            });
            Console.WriteLine("Done!");
            break;
        case "2":
            var todos = todoService.GetTodos();
            Console.WriteLine("List of todos: ");
            var i = 0;
            foreach (var todo in todos)
            {
                 i++;
                Console.WriteLine($"Number: {i} Title: {todo.Title} Description: {todo.Description} Duedate: {todo.DueDate} Priority: {todo.Priority} Completed? {todo.IsCompleted}");
            }
            break;
    }
}