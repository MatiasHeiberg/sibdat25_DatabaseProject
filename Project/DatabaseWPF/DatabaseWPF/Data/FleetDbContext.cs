using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DatabaseWPF.Data
{
    public class FleetDbContext : DbContext
    {

        public DbSet<Model.Vehicle> => Set<Vehicle>
        public DbSet<Model.Employee> Employees => Set<Employee>();
        public DbSet<Model.Assignment> Assignments => Set<Assignment>();
        public DbSet<Model.Maintenance> Maintenances => Set<Maintenance>();

    }
}
