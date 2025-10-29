using Core.Domain.Mappers;
using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class VehicleService
    {
        VehicleRepository vehicleRepository = new VehicleRepository();
        public void AddVehicle(Vehicle vehicle)
        {
            //ToDo: validatie

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
            List<VehicleDTO> vehicleDTOs = vehicleRepository.GetVehicles();
            List<Vehicle> vehicles = new List<Vehicle>();
            
            foreach (VehicleDTO vehicleDTO in vehicleDTOs)
            {
                if (vehicleDTO is TruckDTO truckDTO)
                {
                    Vehicle vehicleModel = TruckMapper.MapToModel(truckDTO);
                    vehicles.Add(vehicleModel);
                }
                else if (vehicleDTO is TaxiDTO taxiDTO)
                {
                    Vehicle vehicleModel = TaxiMapper.MapToModel(taxiDTO);
                    vehicles.Add(vehicleModel);
                }
            }            
            return vehicles;            
        }
    }
}
