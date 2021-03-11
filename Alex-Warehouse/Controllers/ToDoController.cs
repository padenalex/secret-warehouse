using System.Collections.Generic;
using System.Linq;
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
        private readonly ApplicationDbContext _context;

        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<JsonResult> Index()
        {
            List<Todos> todos = await _context.Todos.ToListAsync();
            return Json(todos);
        }
    }
}