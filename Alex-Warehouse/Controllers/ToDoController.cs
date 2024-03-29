using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Secret_Warehouse.Models;
using Secret_Warehouse.Repositories;

namespace Secret_Warehouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        // TODO: Setup repository pattern & new controller funcs
        private readonly IToDoRepository _repo;

        public ToDoController(IToDoRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            List<Todo> todos = await _repo.Get();
            return Json(todos);
        }
       
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            Todo todo = await _repo.GetToDoById(id);
            return Json(todo);
        }
        
        [HttpPost]
        public async Task<JsonResult> CreateNew(string title, string description, bool completed)
        {
            Todo todo = new Todo {Title = title,
                Description = description, Completed = completed};
            _repo.Post(todo);
            return Json(todo);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateTodo(int id, string title, string description, bool completed)
        {
            Todo todo = await _repo.GetToDoById(id);
            if (!string.IsNullOrEmpty(title)) { todo.Title = title; }
            if (!string.IsNullOrEmpty(description)) { todo.Description = description; }
            // invalid logic
            if (completed != null) { todo.Completed = completed; }
            _repo.Update(todo);
            return Json(todo);
        }

        [HttpDelete("{id}")]
        public void DeleteTodo(int id)
        {
            _repo.Delete(id);
        }

    }
}