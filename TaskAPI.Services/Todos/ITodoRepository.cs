using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos(int authorId);
        public Todo GetTodo(int authorId, int Id);
        public Todo AddTodo(int authorId, Todo todo);
        public void UpdateTodo(Todo todo);
        public void DeleteTodo(Todo todo);
    }
}
