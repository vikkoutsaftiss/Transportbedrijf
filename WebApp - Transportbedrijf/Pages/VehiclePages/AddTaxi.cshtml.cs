using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Vehicle
{
    public class AddTaxiModel : PageModel
    {
        [BindProperty]
        public TaxiModel Taxi { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPostAddTaxi()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            VehicleService vehicleService = new VehicleService();
            vehicleService.AddVehicle(Taxi.Map());

            return RedirectToPage("/VehiclePages/List");
        }
    }
}
