
using Microsoft.EntityFrameworkCore;
using Mvcmovie.Models;
namespace Mvcmovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
    }
}