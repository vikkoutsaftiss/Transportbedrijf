using Core.Domain;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Vehicle
{
    public class ListModel : PageModel
    {
        public TaxiDTO Taxi { get; set; }
        public TruckDTO Truck { get; set; }
        public List<VehicleModel> vehicles {  get; set; }
        public void OnGet()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();

            vehicles = new List<VehicleModel>();

            foreach (VehicleDTO vehicleDTO in vehicleRepository.GetVehicles())
            
            {
                if (vehicleDTO is TruckDTO Truck)
                {
                    vehicles.Add(Truck.MapToModel()); 
                    
                }
                else if (vehicleDTO is TaxiDTO Taxi)
                {
                    vehicles.Add(Taxi.MapToModel());                    
                }                         
            }
        }
    }
}
