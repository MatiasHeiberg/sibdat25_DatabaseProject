using System;
using System.Collections.Generic;
using System.Text;
using DatabaseWPF.Model;
using Microsoft.EntityFrameworkCore;

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
    }
}
