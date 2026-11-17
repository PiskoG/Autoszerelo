using Autoszerelo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoszerelo.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Job> Jobs => Set<Job>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasMany(customer => customer.Jobs)
            .WithOne(job => job.Customer)
            .HasForeignKey(job => job.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
        /*elvileg ha törlök 1 ügyfelet,
            akkor a hozzá tartozó munkák is törlődnek*/ 
        
        modelBuilder.Entity<Job>()
            .Property(job => job.Category)
            .HasConversion<string>();
            /*A 
              | adatb olvashatósághoz*/
            
        modelBuilder.Entity<Job>()
            .Property(job => job.Status)
            .HasConversion<string>();
    }
    
    
    
}