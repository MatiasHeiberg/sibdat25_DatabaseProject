using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}
