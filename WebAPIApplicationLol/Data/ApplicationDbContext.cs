using Microsoft.EntityFrameworkCore;
using WebAPIApplicationLol.Models.Entities;

namespace WebAPIApplicationLol.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
