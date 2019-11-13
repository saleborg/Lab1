using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab1_1.Models
{
    public class Lab1_1Context : DbContext
    {
        public Lab1_1Context (DbContextOptions<Lab1_1Context> options)
            : base(options)
        {
        }

        public DbSet<Lab1_1.Models.Person> Person { get; set; }
        public DbSet<Lab1_1.Models.Occupation> Occupation { get; set; }
    }
}
