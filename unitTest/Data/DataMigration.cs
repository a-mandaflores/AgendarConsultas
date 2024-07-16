using AgendarConsultas.Model;
using Microsoft.EntityFrameworkCore;

namespace AgendarConsultas.Data;
public class DataMigration(DbContextOptions<DataMigration> options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Clinic> Clinic { get; set; }
    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Secretary> Secretary { get; set; }



};

