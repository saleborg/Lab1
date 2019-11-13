using System.ComponentModel.DataAnnotations;

namespace Lab1_1.Models
{
    public class Occupation
    {
        [Key]
        public int Id { get; set; }
        public string OccupationName { get; set; }
    }
}