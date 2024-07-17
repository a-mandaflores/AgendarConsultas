using AgendarConsultas.Model;
using Microsoft.EntityFrameworkCore;

namespace AgendarConsultas.Data;
public class ScheduleContext(DbContextOptions<ScheduleContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Clinic>()
            .HasOne(c => Secretary)
            .WithMany()
            .HasForeignKey(c => Secretary)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Secretary>()
            .HasOne(c => Secretary)
            .WithMany()
            .HasForeignKey(c => Secretary)
            .OnDelete(DeleteBehavior.Cascade);
    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Clinic> Clinic { get; set; }
    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Secretary> Secretary { get; set; }
    public DbSet<Veterinary> Veterinarys { get; set; }


};

