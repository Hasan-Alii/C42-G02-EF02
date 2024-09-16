using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF02.Data.Models
{
    internal class Product
    {
        // old method -> method number 1: By Convention

        // method number 2: Data Annotation:
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

    }
}
