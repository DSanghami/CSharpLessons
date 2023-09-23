using System.ComponentModel.DataAnnotations;

namespace FirstMVCapp.Models
{
    public class EmpTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Name must be 3 and 20")]


        public string name { get; set; } = string.Empty;

        [Required]
        [Range(1000, 5000000)]
        public decimal salary { get; set; }



        [StringLength(20)]
        [MinLength(3, ErrorMessage = "city must be between 3 and 20 char")]
        public string city { get; set; } = string.Empty;


    }
}
