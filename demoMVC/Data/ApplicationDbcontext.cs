using demoMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace demoMVC.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student {get; set;}
    }
}