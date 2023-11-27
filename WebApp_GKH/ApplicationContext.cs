using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
   // public DbSet<User> Users { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=45.143.93.41;Port=5432;Database=db_edu;Username=edu;Password=edu");
    }
}
