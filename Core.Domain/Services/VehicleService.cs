using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class VehicleService
    {
        public void AddVehicle(Vehicle vehicle)
        {
            //ToDo: validatie
            VehicleRepository vehicleRepository = new VehicleRepository();

            if (vehicle is Truck truck)
            {
                vehicleRepository.AddVehicle(new TruckDTO()
                {
                    VehicleBrandModel = vehicle.VehicleBrandModel,
                    VehicleType = Convert.ToInt32(vehicle.VehicleType),
                    LicencePlate = vehicle.LicencePlate,
                    TotalDriven = vehicle.TotalDriven,
                    MaxLoad = truck.MaxLoad,
                });
            }
            else if (vehicle is Taxi taxi)
            {
                vehicleRepository.AddVehicle(new TaxiDTO()
                {
                    VehicleBrandModel = vehicle.VehicleBrandModel,
                    VehicleType = Convert.ToInt32(vehicle.VehicleType),
                    LicencePlate = vehicle.LicencePlate,
                    TotalDriven = vehicle.TotalDriven,
                    MaxPersons = taxi.MaxPersons
                });

            }
            
        }
    }
}
