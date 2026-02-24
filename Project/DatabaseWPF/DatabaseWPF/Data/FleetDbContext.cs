using System;
using System.Collections.Generic;
using System.Text;
using DatabaseWPF.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DatabaseWPF.Data
{
    public class FleetDbContext : DbContext
    {
        private readonly string connectionString = "Server=.\\SQLEXPRESS;Database=FleetDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Assignment> Assignments => Set<Assignment>();
        public DbSet<Maintenance> Maintenances => Set<Maintenance>();
        public DbSet<Activity> Activities => Set<Activity>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.Property(x => x.Surname).HasMaxLength(30).IsRequired();
                e.Property(x => x.FirstName).HasMaxLength(30).IsRequired();
                e.Property(x => x.Role).HasMaxLength(20);
                e.Property(x => x.PhoneNumber).HasMaxLength(20);
                e.HasIndex(x => x.PhoneNumber).IsUnique();
                e.Property(x => x.EmployeeIsActive).HasDefaultValue(true).IsRequired();
            });

            modelBuilder.Entity<Vehicle>(v =>
            {
                v.Property(x => x.NumberPlate).HasMaxLength(30);
                v.HasIndex(x => x.NumberPlate).IsUnique();
                v.Property(x => x.VehicleIsActive).HasDefaultValue(true).IsRequired();
                v.Property(x => x.VehicleType).HasMaxLength(30);
                v.Property(x => x.NextServiceDate).HasColumnType("date");
                v.Property(x => x.NextInspectionDate).HasColumnType("date");
            });

            modelBuilder.Entity<Assignment>(a =>
            {
                a.Property(x => x.StreetName).HasMaxLength(100);
                a.Property(x => x.HouseNumber).HasMaxLength(10);
                a.Property(x => x.PostalCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Maintenance>(m =>
            {
                m.Property(x => x.MaintenanceDate).HasColumnType("date").IsRequired();
                m.Property(x => x.MaintenanceType).HasMaxLength(30);
            });

            modelBuilder.Entity<Activity>(a =>
            {
                a.Property(x => x.StartDate).HasColumnType("date");
                a.Property(x => x.EndDate).HasColumnType("date");
            });
        }
    }
}
