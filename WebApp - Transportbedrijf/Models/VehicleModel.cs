using System.ComponentModel.DataAnnotations;

namespace WebApp___Transportbedrijf.Models
{
    public class VehicleModel
    {
        [Required(ErrorMessage = "Vul een merk- en modelnaam in om door te gaan.")]
        [StringLength(100, MinimumLength = 5)]
        [Display(Name = "Merk en model:")]
        public string vehicleBrandModel { get; set; }

        [Required(ErrorMessage = "Kies een voertuigsoort in om door te gaan.")]
        [Display(Name = "Soort voertuig:")]
        public int VehicleType { get; set; } //moet een dropdown worden ivm enum

        [Required(ErrorMessage = "Vul een kenteken in om door te gaan.")]
        [StringLength (8, MinimumLength = 8)]
        [Display(Name = "Kenteken:")]
        public string LicencePlate { get; set; }

        [Display(Name = "Maximaal trekgewicht (kg):")]
        public int? MaxLoad { get; set; }

        [Display(Name = "Maximaal aantal passagiers:")]
        public int? MaxPersons { get; set; }

    }
}
