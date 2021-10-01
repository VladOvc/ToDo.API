using Microsoft.EntityFrameworkCore;

namespace ToDo.API.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoContext(DbContextOptions<TodoContext> option) : base(option)
        {

        }
    }
}
