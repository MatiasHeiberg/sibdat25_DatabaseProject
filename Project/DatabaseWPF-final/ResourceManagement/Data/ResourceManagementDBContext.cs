using Microsoft.EntityFrameworkCore;
using ResourceManagement.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace ResourceManagement.Data
{
    public class ResourceManagementDBContext : DbContext
    {
        private readonly string _connectionString = "Server=.\\SQLEXPRESS;Database=ResourceManagementDB;Trusted_Connection=True;Encrypt=False";

        DbSet<Vehicle> Vehicle { get; set; }

        DbSet<Employee> Employee { get; set; }

        DbSet<Maintenance> Maintenance { get; set; }

        DbSet<ResourceManagement.Model.Task> Task { get; set; }

        DbSet<TaskAssignment> TaskAssignment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.Property(x => x.Surname).HasMaxLength(30);
                e.Property(x => x.FirstName).HasMaxLength(30);
                e.Property(x => x.Role).HasMaxLength(20);
                e.Property(x => x.PhoneNumber).HasMaxLength(20);
                e.HasIndex(x => x.PhoneNumber).IsUnique();
            });

            modelBuilder.Entity<Vehicle>(v =>
            {
                v.Property(x => x.LicensePlate).HasMaxLength(30);
                v.HasIndex(x => x.LicensePlate).IsUnique();
                v.Property(x => x.Type).HasMaxLength(30);
                v.Property(x => x.NextService).HasColumnType("date");
                v.Property(x => x.LastInspection).HasColumnType("date");
            });

            modelBuilder.Entity<ResourceManagement.Model.Task>(t =>
            {
                t.Property(x => x.StreetName).HasMaxLength(100);
                t.Property(x => x.HouseNumber).HasMaxLength(10);
                t.Property(x => x.StartTime).HasColumnType("datetime");
                t.Property(x => x.EndTime).HasColumnType("datetime");
                t.Property(x => x.PostalCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Maintenance>(m =>
            {
                m.Property(x => x.Date).HasColumnType("datetime");
                m.Property(x => x.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<TaskAssignment>(a =>
            {
                a.Property(x => x.StartTime).HasColumnType("datetime");
                a.Property(x => x.EndTime).HasColumnType("datetime");
            });
        }



    }
}
