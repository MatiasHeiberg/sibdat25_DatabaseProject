using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
    }
}
