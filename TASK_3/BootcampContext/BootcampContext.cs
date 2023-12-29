using Microsoft.EntityFrameworkCore;
using netBootcamp.TASK_3;
using netBootcamp.TASK_4;

namespace netBootcamp.TASK_3.BootcampContext
{
    public class BootcampContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF; Database = NetBootcamp; trusted_connection=true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
