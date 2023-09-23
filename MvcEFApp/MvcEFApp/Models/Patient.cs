using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEFApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 chars")]

        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
       
        [Column(TypeName = "Numeric(18,0")]
        public decimal PhoneNumber { get; set; }
    }
}
