using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Familie
    {
        public int FamilieId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }
        [StringLength(30,MinimumLength = 10)]
        public string Orde { get; set; }
        [Required]
        public string Klasse { get; set; }
    }
}
