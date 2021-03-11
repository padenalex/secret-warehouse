using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Secret_Warehouse.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Thing> Things { get; set; }
        public DbSet<Todos> Todos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {  }
        
        public List<Thing> getThings () => Things.ToList<Thing>();
    }
}