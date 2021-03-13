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
        
        public async Task<IEnumerable<Todo>> Get()
        {
            var todos = await _context.Todos.ToListAsync();     
            return todos;
        }

        public async void Post(Todo todo)
        {
            if(todo == null) { throw new ArgumentNullException(nameof(todo)); }
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
        }
    }
}