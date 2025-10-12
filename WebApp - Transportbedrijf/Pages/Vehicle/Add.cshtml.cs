using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Vehicle
{
    public class AddModel : PageModel
    {
        //public VehicleModel Vehicle { get; set; } = new();
        [BindProperty]
        public TaxiModel Taxi { get; set; } = new();
        [BindProperty]
        public TruckModel Truck { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPostAddTruck()
        {
            ModelState.ClearValidationState(nameof(Taxi));

            ModelState.ClearValidationState(nameof(Truck));
            TryValidateModel(Truck, nameof(Truck));

            if (!ModelState.IsValid)
            {
                return Page();
            }

            VehicleService vehicleService = new VehicleService();
            vehicleService.AddVehicle(Truck.Map());

            return RedirectToPage("Vehicle/List");
        }

        public IActionResult OnPostAddTaxi()
        {
            ModelState.ClearValidationState(nameof(Truck));

            ModelState.ClearValidationState(nameof(Taxi));
            TryValidateModel(Taxi, nameof(Taxi));

            if (!ModelState.IsValid)
            {
                return Page();
            }

            VehicleService vehicleService = new VehicleService();
            vehicleService.AddVehicle(Taxi.Map());

            return RedirectToPage("/Vehicle/List");
        }
    }
}

