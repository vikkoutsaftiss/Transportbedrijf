using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Vehicle
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public VehicleModel Vehicle { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            VehicleService vehicleService = new VehicleService();
            vehicleService.AddVehicle(new Core.Domain.Vehicle(Vehicle.vehicleBrandModel, (Core.Domain.VehicleType)Vehicle.VehicleType, Vehicle.LicencePlate, Vehicle.MaxLoad, Vehicle.MaxPersons));
            //linkt het object Vehicle in deze klasse aan het object Vehicle in Core.Domain. Link tussen UI en Domain wordt op deze manier gelegd.


            //ToDo: Landingspagina/notificatie maken ter bevestiging van toevoegen voertuig.
            return RedirectToPage();
        }
    }
}
