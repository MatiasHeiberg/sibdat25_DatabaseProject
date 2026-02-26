using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagement.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
