using System;
using System.ComponentModel.DataAnnotations;

namespace AppStudent.Models
{
    public class MyStud
    {
        public int ID { get; set; }
        [StringLength(10, MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z]+$")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]+$")]
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }
        [RegularExpression("^[a-zA-Z]+$")]
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Parentage { get; set; }
    }
}
