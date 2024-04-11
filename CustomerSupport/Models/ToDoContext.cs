using Microsoft.EntityFrameworkCore;

namespace CustomerSupport.Models
{
    public class ToDoContext : DbContext
    {

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId="open", StatusName="Open" },
                new Status { StatusId = "closed", StatusName = "Completed" }
            );
        }

    }
}
