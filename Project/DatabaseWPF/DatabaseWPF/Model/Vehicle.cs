using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Numberplate { get; set; }
        public bool VehicleStatus { get; set; }
        public string VehicleType { get; set; }
        public DateOnly NextServiceDate { get; set; }
        public DateOnly NextInspectionDate { get; set; }

    }
}
