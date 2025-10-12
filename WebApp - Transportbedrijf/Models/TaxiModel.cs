using System.ComponentModel.DataAnnotations;

namespace WebApp___Transportbedrijf.Models
{
    public class TaxiModel : VehicleModel
    {
        [Required]
        [Display(Name = "Maximaal aantal passagiers:")]
        [Range(4, 10)]
        public int MaxPersons { get; set; }
    }
}
