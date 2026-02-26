using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagement.Model
{
    public class Maintenance
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Type { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
