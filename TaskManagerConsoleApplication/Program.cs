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
            Console.WriteLine("Enter todo priority");
            var priority = Console.ReadLine();
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
            todoService.GetTodos();
            break;
    }
}