﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int authorID)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authorId);
        }

        public Todo AddTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;

            _context.Todos.Add(todo);
            _context.SaveChanges();

            return _context.Todos.Find(todo.Id);
        }

        public void UpdateTodo(Todo todo)
        {
            _context.SaveChanges();
        }

        public void DeleteTodo(Todo todo)
        {
            _context.Remove(todo);
            _context.SaveChanges();
        }
    }
}
