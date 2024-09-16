using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02_demo.Entities
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int InstructorID { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
