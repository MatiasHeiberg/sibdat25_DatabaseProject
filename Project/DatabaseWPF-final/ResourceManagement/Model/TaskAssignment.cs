using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagement.Model
{
    public class TaskAssignment
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; } 
        public DateTime? EndTime { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }
        public int? TaskId { get; set; }
        public Task? Task { get; set; }
    }
}
