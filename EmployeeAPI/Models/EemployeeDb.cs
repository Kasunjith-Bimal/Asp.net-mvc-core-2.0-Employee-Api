using System;
using System.Collections.Generic;

namespace EmployeeAPI.Models
{
    public partial class EemployeeDb
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? EmployeeAge { get; set; }
        public string EmployeeTelephone { get; set; }
    }
}
