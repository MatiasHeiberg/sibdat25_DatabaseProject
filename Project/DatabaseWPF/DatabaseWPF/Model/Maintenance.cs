using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public DateOnly MaintenanceDate { get; set; }
        public string MaintenanceType { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
