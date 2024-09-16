using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02_demo.Entities
{
    internal class StudentCourse
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public double Grade { get; set; }
    }
}
