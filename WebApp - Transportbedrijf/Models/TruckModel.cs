using System.ComponentModel.DataAnnotations;

namespace WebApp___Transportbedrijf.Models
{
    public class TruckModel : VehicleModel
    {
        [Required]
        [Range(1000, 3000)]
        [Display(Name = "Maximaal trekgewicht (kg):")]
        public int MaxLoad { get; set; }
    }
}
