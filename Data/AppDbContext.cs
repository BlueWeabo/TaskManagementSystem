namespace TaskManagementSystem.Data;

using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;

public class AppDbContext : DbContext {

    public DbSet<Task> Tasks {get; set;}
    public DbSet<Comment> Comments {get; set;}
    public DbSet<User> Users {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        // connect to postgres with connection string from app settings
        options.UseNpgsql("host=localhost; database=taskmanagementsystem; username=tasksystem; password=tasksystem");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
    }
}
