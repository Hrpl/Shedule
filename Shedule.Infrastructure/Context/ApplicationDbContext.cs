
using Microsoft.EntityFrameworkCore;
using Shedule.Domain.Entities;

namespace Shedule.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Discipline> Disciplines { get; set; }  
    public DbSet<Group> Groups { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Time> Times { get; set; }
    public DbSet<User> Users { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
        this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}
