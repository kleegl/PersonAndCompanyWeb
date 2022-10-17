using Microsoft.EntityFrameworkCore;
using PersonAndCompanyWebProject.Models;

namespace PersonAndCompanyWebProject.Databases
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Company> Companies { get; set; }
        public DbSet<Person> Persons { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
