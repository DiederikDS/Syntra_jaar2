using System.ComponentModel.DataAnnotations;

namespace MVC_Klas.Models
{
    public class Dier
    {
        [Required(AllowEmptyStrings = false)]
        public string Benaming { get; set; }
        [MaxLength(15, ErrorMessage = "De Familie mag niet langer zijn dan 15 karakters")]
        [Display(Name = "Familie Naam")]
        public string Familie { get; set; }
        public bool Gevaarlijk { get; set; }
    }
}
