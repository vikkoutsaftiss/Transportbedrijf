using Core.Domain.Models.Transport;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TransporT.Services.Services;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Transport
{
    public class ListModel : PageModel
    {
        public CargoRequest Cargo { get; set; }
        public TaxiRequest Taxi { get; set; }
        public List<TransportModel> TransportModels { get; set; } = new List<TransportModel>();
        public void OnGet()
        {
            TransportService transportService = new TransportService();
            List<TransportRequest> transportRequests = transportService.GetTransportRequests();

            foreach (TransportRequest transportRequest in transportRequests)
            {
                TransportModel transportModel = new TransportModel();

                if (transportRequest is CargoRequest cargoRequest)
                {
                    transportModel = CargoRequestMapper.MapToModel(cargoRequest);
                }
                else if (transportRequest is TaxiRequest taxiRequest)
                {
                    transportModel = TaxiRequestMapper.MapToModel(taxiRequest);
                }

                TransportModels.Add(transportModel);
            }
        }
    }
}
