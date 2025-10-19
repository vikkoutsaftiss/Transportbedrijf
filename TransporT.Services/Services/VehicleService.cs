using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Mappers;
using Infrastructure.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Models.Vehicles;

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
                vehicleRepository.AddVehicle(TruckMapper.MapToDTO(truck));
            }
            else if (vehicle is Taxi taxi)
            {
                vehicleRepository.AddVehicle(TaxiMapper.MapToDTO(taxi));
            }
            
        }

        public List<Vehicle> GetVehicles()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<VehicleDTO> vehicleDTOs = vehicleRepository.GetVehicles();
            List<Vehicle> vehicles = new List<Vehicle>();
            
            foreach (VehicleDTO vehicleDTO in vehicleDTOs)
            {
                Vehicle vehicleModel = MapToVehicle(vehicleDTO);

                vehicles.Add(vehicleModel);
            }
            
            return vehicles;
            
            
        }

        private Vehicle MapToVehicle(VehicleDTO vehicleDTO)
        {
            if (vehicleDTO is TruckDTO truckDTO)
            {
                return new Truck(
                    truckDTO.VehicleBrandModel,
                    truckDTO.VehicleType,
                    truckDTO.LicencePlate,
                    truckDTO.MaxLoad);
            }
            else if(vehicleDTO is TaxiDTO taxiDTO)
            {
                return new Taxi(
                    taxiDTO.VehicleBrandModel,
                    taxiDTO.VehicleType,
                    taxiDTO.LicencePlate,
                    taxiDTO.MaxPersons);
            }

            throw new ArgumentException("$Onbekend voertuig");
          
        }
    }
}
