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
            vehicleRepository.AddVehicle(new VehicleDTO() 
            { 
                VehicleBrandModel = vehicle.VehicleBrandModel, 
                VehicleType = Convert.ToInt32(vehicle.VehicleType),
                LicencePlate = vehicle.LicencePlate, 
                TotalDriven = vehicle.TotalDriven,
                MaxLoad = vehicle.MaxLoad,
                MaxPersons = vehicle.MaxPersons
            });
        }
    }
}
