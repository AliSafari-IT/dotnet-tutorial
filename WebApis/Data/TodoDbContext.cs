// TodoDbContext.cs
using Microsoft.EntityFrameworkCore;
using WebApis.Models;

namespace WebApis.Data;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

}

