using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02_demo.Entities
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public decimal HourRate { get; set; }
        public int DepartmentID { get; set; }

    }
}
