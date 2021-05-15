using Microsoft.EntityFrameworkCore;

namespace Giansar.Demo.TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Database=demo_todo_api;Username=demo_db;Password=demo_db_password");
    }
}