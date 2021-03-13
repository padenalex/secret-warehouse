using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Secret_Warehouse.Models;

namespace Secret_Warehouse.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private ApplicationDbContext _context;

        public ToDoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Todo>> Get()
        {
            List<Todo> todos = _context.Todos.ToList();     
            return todos;
        }

        public Todo GetToDoById(int id)
        {
            Todo todo = _context.Todos.Find(id);
            return todo;
        }

        public async void Post(Todo todo)
        {
            if(todo == null) { throw new ArgumentNullException(nameof(todo)); }
            await _context.Todos.AddAsync(todo);
            Save();
        }

        public async void Update(Todo todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            Save();
        }

        public void Delete(int? id)
        {
            Todo todo = _context.Todos.Find(id);
            if (todo != null) _context.Todos.Remove(todo);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}