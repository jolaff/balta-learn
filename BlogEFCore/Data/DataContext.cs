using BlogEFCore.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace BlogEFCore.Data;

public class DataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost,1433;Database=BlogLearn;User ID=sa;Password=1029384756!@#;TrustServerCertificate=True");
        // options.LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new UserMap());
        modelBuilder.ApplyConfiguration(new PostMap());
    }
}