using Microsoft.EntityFrameworkCore;

namespace netBootcamp.TASK_3.BootcampContext
{
    public class BootcampContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF; Database = NetBootcamp; trusted_connection=true");
        }

        public DbSet<Employee> Employees { get; set;}
    }
}
