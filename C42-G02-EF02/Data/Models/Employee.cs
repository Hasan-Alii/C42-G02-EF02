using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02.Data.Models
{
    // EF Core Supports 4 ways for mapping classes (DBContext, Models) to Database (Tables, Views)
    // 1. By Convention (Default Behaviour)

    internal class Employee
    {
        public int Id { get; set; } // Public Numeric Property "Id" or "EmployeeId" --> PK [Identity Constraint (1, 1)]
        public string? Name { get; set; } // Reference Type: Allows Null [Optional]  
        public double Salary { get; set; } // Value Type: Doesn't Allow Null [Required]
        public int? Age { get; set; } // Nullabe<int>: Allows Null [Optional]
    

    }
}
