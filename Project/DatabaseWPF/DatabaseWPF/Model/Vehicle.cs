using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; } //Primary key.
        public string? NumberPlate { get; set; } //NULL, max 30, UNIQUE.
        public bool VehicleIsActive { get; set; } = true; //NOT NULL, DEFAULT 1.
        public string? VehicleType { get; set; } //NULL, max 20.
        public DateOnly? NextServiceDate { get; set; } //NULL, DATE.
        public DateOnly? NextInspectionDate { get; set; } //NULL, DATE.

    }
}
