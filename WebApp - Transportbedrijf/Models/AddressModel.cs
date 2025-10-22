using System.ComponentModel.DataAnnotations;

namespace WebApp___Transportbedrijf.Models
{
    public class AddressModel
    {
        [Required(ErrorMessage = "Vul een straatnaam en huisnummer in om door te gaan.")]
        [Display(Name = "Straat en huisnummer:")]
        public string StreetAndNumber { get; set; }

        [Required(ErrorMessage = "Vul een postcode in om door te gaan.")]
        [Display(Name = "Postcode:")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Vul een plaatsnaam in om door te gaan.")]
        [Display(Name = "Plaatsnaam:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Vul een land in om door te gaan.")]
        [Display(Name = "Land:")]
        public string Country { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
