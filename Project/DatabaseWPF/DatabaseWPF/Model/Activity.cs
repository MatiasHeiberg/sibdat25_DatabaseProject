using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Activity
    {
        public int ActivityId { get; set; } //Primary key.
        public DateTime? StartDate { get; set; } //NULL, DATE.
        public DateTime? EndDate { get; set; } //NULL, DATE.

        public int EmployeeId { get; set; } //Foreign key.
        public Employee Employee { get; set; } = null!;

        public int AssignmentId { get; set; } //Foreign key.
        public Assignment Assignment { get; set; } = null!;

        public int VehicleId { get; set; } //Foreign key.
        public Vehicle Vehicle { get; set; } = null!;
    }
}
