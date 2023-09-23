using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEFApp.Models

{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(1, ErrorMessage ="Name must be between 3 and 20 letters")]

        public string Name { get; set; } = string.Empty;
        [Required]
        public string Speaciality { get; set; }=string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName ="Numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "Numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }
}
