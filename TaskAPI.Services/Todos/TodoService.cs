using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        //Get Todos
        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books",
                Description = "For school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Finish project report",
                Description = "Compile all sections and review",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.InProgress
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Buy groceries",
                Description = "Milk, eggs, bread, and vegetables",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };
            todos.Add(todo3);

            var todo4 = new Todo
            {
                Id = 4,
                Title = "Car service",
                Description = "Oil change and tire rotation",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodoStatus.New
            };
            todos.Add(todo4);

            var todo5 = new Todo
            {
                Id = 5,
                Title = "Call plumber",
                Description = "Fix leaky faucet in kitchen",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            };
            todos.Add(todo5);

            var todo6 = new Todo
            {
                Id = 6,
                Title = "Plan vacation",
                Description = "Research flights and accommodations",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(30),
                Status = TodoStatus.New
            };
            todos.Add(todo6);

            var todo7 = new Todo
            {
                Id = 7,
                Title = "Complete tax returns",
                Description = "Gather necessary documents",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(15),
                Status = TodoStatus.InProgress
            };
            todos.Add(todo7);

            var todo8 = new Todo
            {
                Id = 8,
                Title = "Read a book",
                Description = "Pick up 'Atomic Habits' from library",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(14),
                Status = TodoStatus.Completed
            };
            todos.Add(todo8);

            var todo9 = new Todo
            {
                Id = 9,
                Title = "Schedule dentist appointment",
                Description = "Routine check-up",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(20),
                Status = TodoStatus.New
            };
            todos.Add(todo9);

            var todo10 = new Todo
            {
                Id = 10,
                Title = "Organize closet",
                Description = "Sort clothes to keep and donate",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(6),
                Status = TodoStatus.New
            };
            todos.Add(todo10);

            var todo11 = new Todo
            {
                Id = 11,
                Title = "Exercise",
                Description = "30 minutes of running",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };
            todos.Add(todo11);


            return todos;
        }

        public Todo GetTodo(int authorId, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
