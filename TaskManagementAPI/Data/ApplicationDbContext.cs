using Microsoft.EntityFrameworkCore;

namespace TaskManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
