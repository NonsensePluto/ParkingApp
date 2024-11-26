using Microsoft.EntityFrameworkCore;
using ParkingAppSolution.DataAccess.Entities;

namespace ParkingAppSolution.DataAccess;

public class ParkingDbContext:DbContext
{
    public DbSet<ParkingTypeEntity> ParkingTypes { get; set; }
    public DbSet<ParkingEntity> Parkings { get; set; }
    public DbSet<ParkingPlaceTypeEntity> ParakingPlaceTypes { get; set; }
    public DbSet<ParkingPlaceEntity> ParkingPlaces { get; set; }
    public DbSet<PasportEntity> Pasports { get; set; }
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<DriverCategoryEntity> DriverCategories { get; set; }
    public DbSet<CarTypeEntity> CarTypes { get; set; }
    public DbSet<CarMarkEntity> CarMarks { get; set; }
    public DbSet<CarModelEntity> CarModels { get; set; }
    public DbSet<CarEntity> Cars { get; set; }
    public DbSet<ContractEntity> Contracts { get; set; }
    public DbSet<WorkerEntity> Workers { get; set; }
    public DbSet<DriverEntity> Drivers { get; set; }
    public DbSet<CarDriverEntity> CarDrivers { get; set; }
    public DbSet<DriverCategoryDriverEntity> DriverCategoryDrivers { get; set; }
    public DbSet<SecurityEntity> Securities { get; set; }

    public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParkingTypeEntity>().HasKey(pk => pk.Id);
        
        
        modelBuilder.Entity<ParkingEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<ParkingEntity>().HasOne(pk => pk.ParkingType)
            .WithMany(p => p.Parkings)
            .HasForeignKey(pk => pk.Id);
        

        modelBuilder.Entity<ParkingPlaceTypeEntity>().HasKey(pk => pk.Id);
        

        modelBuilder.Entity<ParkingPlaceEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<ParkingPlaceEntity>().HasOne(pk => pk.ParkingPlaceType)
            .WithMany(p => p.ParkingPlaces)
            .HasForeignKey(pk => pk.Id);
        
        modelBuilder.Entity<PasportEntity>().HasKey(pk => pk.Id);
        
        modelBuilder.Entity<ClientEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<ClientEntity>().HasOne(pk => pk.Pasport)
            .WithMany(p => p.Clients)
            .HasForeignKey(p => p.PasportNumber);
        
        modelBuilder.Entity<CarTypeEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<CarTypeEntity>().HasOne(pk => pk.DriverCategory)
            .WithMany(p => p.CarTypes)
            .HasForeignKey(pk => pk.Id);//
        
        modelBuilder.Entity<CarMarkEntity>().HasKey(pk => pk.Id);
        
        modelBuilder.Entity<CarModelEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<CarModelEntity>().HasOne(pk => pk.CarMark)
            .WithMany(p => p.CarModels)
            .HasForeignKey(pk => pk.CarMarkId);

        modelBuilder.Entity<CarEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<CarEntity>().HasOne(pk => pk.CarType)
            .WithMany(p => p.Cars)
            .HasForeignKey(pk => pk.CarTypeId);
        modelBuilder.Entity<CarEntity>().HasOne(pk => pk.CarMark)
            .WithMany(p => p.Cars)
            .HasForeignKey(pk => pk.CarMarkId);
        
        modelBuilder.Entity<ContractEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<ContractEntity>().HasOne(pk => pk.Client)
            .WithMany(p => p.Contracts)
            .HasForeignKey(pk => pk.ClientId);
        modelBuilder.Entity<ContractEntity>().HasOne(pk => pk.Car)
            .WithMany(p => p.Contracts)
            .HasForeignKey(pk => pk.CarId);
        modelBuilder.Entity<ContractEntity>().HasOne(pk => pk.ParkingPlace)
            .WithMany(p => p.Contracts)
            .HasForeignKey(pk => pk.ParkingPlaceId);
        
        modelBuilder.Entity<WorkerEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<WorkerEntity>().HasOne(pk => pk.Pasport)
            .WithMany(p => p.Workers)
            .HasForeignKey(pk => pk.PasportNumber);
        
        modelBuilder.Entity<DriverEntity>()
            .HasOne(pk => pk.Worker)
            .WithOne(p => p.Driver);
        
        modelBuilder.Entity<CarDriverEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<CarDriverEntity>().HasOne(pk => pk.Driver)
            .WithMany(p => p.CarDrivers)
            .HasForeignKey(pk => pk.DriverId);
        modelBuilder.Entity<CarDriverEntity>().HasOne(pk => pk.Car)
            .WithMany(p => p.CarDrivers)
            .HasForeignKey(pk => pk.CarId);

        modelBuilder.Entity<DriverCategoryDriverEntity>().HasKey(pk => pk.Id);
        modelBuilder.Entity<DriverCategoryDriverEntity>().HasOne(pk => pk.DriverCategory)
            .WithMany(p => p.DriverCategoriesDrivers)
            .HasForeignKey(pk => pk.DriverCategoryId);
        modelBuilder.Entity<DriverCategoryDriverEntity>().HasOne(pk => pk.Driver)
            .WithMany(p => p.DriverCategoriesDrivers)
            .HasForeignKey(pk => pk.DriverId);
        
        modelBuilder.Entity<SecurityEntity>().HasOne(pk => pk.Worker)
            .WithOne(p => p.Security);
    }
}