using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secret_Warehouse.Models;

namespace Secret_Warehouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DbController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Thing> users = _context.getThings();
            return Ok(users);
        }
    }
}