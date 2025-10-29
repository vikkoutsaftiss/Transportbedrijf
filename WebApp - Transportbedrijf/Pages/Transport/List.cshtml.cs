using Core.Domain.Models.Transport;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Transport
{
    public class ListModel : PageModel
    {
        public CargoRequest Cargo { get; set; }
        public TaxiRequest Taxi { get; set; }
        public List<TransportModel> TransportModels { get; set; }
        public void OnGet()
        {
        }
    }
}
