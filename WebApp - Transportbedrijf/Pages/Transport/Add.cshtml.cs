using TransporT.Shared.Models;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using WebApp___Transportbedrijf.Models;
using WebApp___Transportbedrijf.Helpers.Mappers;
using TransporT.Services;
using TransporT.Services.Services;


namespace WebApp___Transportbedrijf.Pages.Transport
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public TransportModel Transport { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TransportService transportService = new TransportService();
            transportService.AddTransport(Transport.Map());

            return RedirectToPage("/VehiclePages/List");
        }
    }
}
