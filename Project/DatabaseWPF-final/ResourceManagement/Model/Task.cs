using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagement.Model
{
    public class Task
    {
        public int Id { get; set; }
        public string? StreetName { get; set; }
        public string? HouseNumber { get; set; }
        public string? PostalCode { get; set; } 
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
