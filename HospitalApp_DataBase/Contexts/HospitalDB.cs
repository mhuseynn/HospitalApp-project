using HospitalApp_Model.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HospitalApp_DataBase.Contexts;

internal class HospitalDB : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var ConStr = new ConfigurationManager()
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("DefaultConnection");

        

        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(ConStr);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
        
        modelBuilder.Entity<Admin>().HasData(
        new Admin { FirstName = "Huseyn", LastName = "Mehdiyev", UserName = "huseyn", Password = "123",  Id  = 1  });

       
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Admin>? Admins { get; set; }
    public virtual DbSet<User>? Users { get; set; }
    public virtual DbSet<Doctor>? Doctors { get; set; }
    public virtual DbSet<Appointment>? Appointments { get; set; }
    public virtual DbSet<Department>? Departments { get; set; }
    public virtual DbSet<Analiz>? Analises { get; set; }
}

