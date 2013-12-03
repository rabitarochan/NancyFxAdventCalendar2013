using System.Data.Entity;

namespace TodoApp.Models
{
    public class TodoAppContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; } 
    }
}