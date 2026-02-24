using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWPF.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; } //Primary key

        public string FirstName { get; set; } = null!; //NOT NULL, max 30.
        public string Surname { get; set; } = null!; //NOT NULL, max 30.

        public string? Role { get; set; } //NULL, max 20.
        public string? PhoneNumber { get; set; } //NULL, max 20, UNIQUE.

        public bool EmployeeIsActive { get; set; } = true; //NOT NULL, DEFAULT 1.

    }
}
