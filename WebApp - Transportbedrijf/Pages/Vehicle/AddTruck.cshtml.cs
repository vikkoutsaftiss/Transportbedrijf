using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Vehicle
{
    public class AddTruckModel : PageModel
    {
        [BindProperty]
        public TruckModel Truck { get; set; } = new();
        public void OnGet()
        {
        }
        public IActionResult OnPostAddTruck()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            VehicleService vehicleService = new VehicleService();
            vehicleService.AddVehicle(Truck.Map());

            return RedirectToPage("/Vehicle/List");
        }
    }
}
