using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; } //Primary key.

        public DateOnly MaintenanceDate { get; set; } //NOT NULL, DATE.
        public string? MaintenanceType { get; set; } //NULL, max 30.

        public int VehicleId { get; set; } //NOT NULL, Foreign key.
        public Vehicle Vehicle { get; set; } = null!;
    }
}
