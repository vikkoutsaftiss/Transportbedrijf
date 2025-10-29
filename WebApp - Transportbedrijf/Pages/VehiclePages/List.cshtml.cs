using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp___Transportbedrijf.Helpers.Mappers;
using WebApp___Transportbedrijf.Models;
using Core.Domain.Services;
using Core.Domain.Models.Vehicles;

namespace WebApp___Transportbedrijf.Pages.VehiclePages
{
    public class ListModel : PageModel
    {
        public Taxi Taxi { get; set; }
        public Truck Truck { get; set; }
        public List<VehicleModel> vehicleModels {  get; set; } 
        public void OnGet()
        {
            VehicleService vehicleService = new VehicleService();

            List<Core.Domain.Models.Vehicles.Vehicle> vehicles = vehicleService.GetVehicles();

            vehicleModels = new List<VehicleModel>();

            foreach (Core.Domain.Models.Vehicles.Vehicle vehicle in vehicles)
            {
                VehicleModel vehicleModel = new VehicleModel();             
                
                if (vehicle is Truck truck)
                {
                    vehicleModel = TruckMapper.MapToModel(truck);
                }
                else if (vehicle is Taxi taxi)
                {
                    vehicleModel = TaxiMapper.MapToModel(taxi);
                }

                vehicleModels.Add(vehicleModel);
            }
        }
    }
}
