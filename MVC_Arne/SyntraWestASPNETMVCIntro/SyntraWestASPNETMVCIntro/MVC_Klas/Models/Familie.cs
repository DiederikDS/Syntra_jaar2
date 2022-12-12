using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Familie
    {
        [Key]
        public int FamilieId { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Orde { get; set; }
        [Required]
        public string Klasse { get; set; }
    }
}
