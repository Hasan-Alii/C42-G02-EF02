using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02_demo.Entities
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        [Range(5 , 22)]
        public int Age { get; set; }
        public int DepartmentID { get; set; }
    }
}
