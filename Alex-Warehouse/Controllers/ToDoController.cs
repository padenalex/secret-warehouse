using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Secret_Warehouse.Models;

namespace Secret_Warehouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        // TODO: Setup repository pattern & new controller funcs
        private readonly ApplicationDbContext _context;

        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            List<Todos> todos = await _context.Todos.ToListAsync();
            return Json(todos);
        }
        
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            Todos todo = await _context.Todos.FindAsync(id);
            return Json(todo);
        }
        
        [HttpPost]
        public async Task<JsonResult> CreateNew(string title, string description, bool completed)
        {
            Todos todo = new Todos {Title = title,
                Description = description, Completed = completed};
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
            return Json(todo);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateTodo(int id, string title, string description, bool completed)
        {
            Todos todo = await _context.Todos.FindAsync(id);
            if (!string.IsNullOrEmpty(title)) { todo.Title = title; }
            if (!string.IsNullOrEmpty(description)) { todo.Description = description; }
            if (!completed==false) { todo.Completed = completed; }

            _context.Todos.Update(todo);
            await _context.SaveChangesAsync();
            return Json(todo);
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> DeleteTodo(int id)
        {
            Todos todo = await _context.Todos.FindAsync(id);
            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return Json(todo);
        }
    }
}