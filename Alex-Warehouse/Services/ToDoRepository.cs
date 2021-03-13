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
            List<Todo> todos = await _context.Todos.ToListAsync();     
            return todos;
        }

        public async Task<Todo> GetToDoById(int id)
        {
            Todo todo = await _context.Todos.FindAsync(id);
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

        public async void Delete(int? id)
        {
            Todo todo = await _context.Todos.FindAsync(id);
            if (todo != null) _context.Todos.Remove(todo);
            Save();
        }

        public async void Save()
        {
           await _context.SaveChangesAsync();
        }
    }
}