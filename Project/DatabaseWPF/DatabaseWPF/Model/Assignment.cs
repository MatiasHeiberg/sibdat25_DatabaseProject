using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Assignment
    {
        public int AssignmentId { get; set; } //Primary key.
        public DateOnly StartDate { get; set; } //NULL, DATE.
        public DateOnly EndDate { get; set; } //NULL, DATE.
        public string? StreetName { get; set; } //NULL, max 100.
        public int? HouseNumber { get; set; } //NULL max 10.
        public int? PostalCode { get; set; } //NULL, max 10.
    }
}
