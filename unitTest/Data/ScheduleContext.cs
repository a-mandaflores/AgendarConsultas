using AgendarConsultas.Model;
using Microsoft.EntityFrameworkCore;

namespace AgendarConsultas.Data;

public class ScheduleContext(DbContextOptions<ScheduleContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Clinic>()
              .HasMany(c => c.Secretary) 
              .WithOne(s => s.Clinic)      
              .HasForeignKey(s => s.ClinicId) 
              .OnDelete(DeleteBehavior.Cascade);
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Clinic> Clinic { get; set; }
    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Secretary> Secretarys { get; set; }
    public DbSet<Veterinary> Veterinarys { get; set; }
};