using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TransporT.Services.Services;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Transport
{
    public class AddCargoRequestModel : PageModel
    {
        [BindProperty]
        public CargoRequestModel CargoRequest { get; set; } = new();

        public void OnGet()
        {
            DateTime now = DateTime.Now;
            int minutes = (now.Minute / 15) * 15;

            CargoRequest.DateTime = new DateTime(now.Year, now.Month, now.Day, now.Hour, minutes, 0);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TransportService transportService = new TransportService();
            transportService.AddTransport(CargoRequest.Map());

            return RedirectToPage("/Transport/List");
        }
    }
}
