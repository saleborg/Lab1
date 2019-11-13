using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_1.Models
{
    public class Person
    {
        [Key]
        public string Name { get; set; }
        public int Salary { get; set; }

        [ForeignKey("OccuFK")]
        public virtual Occupation occupation { get; set; }
    }
}
