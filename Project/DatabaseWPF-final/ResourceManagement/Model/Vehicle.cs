using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagement.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? LicensePlate { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Type { get; set; }
        public DateTime? NextService {  get; set; }
        public DateTime? LastInspection { get; set; }
    }
}
