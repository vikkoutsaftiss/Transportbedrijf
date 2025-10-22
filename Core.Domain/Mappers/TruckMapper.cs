using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Mappers
{
    public static class TruckMapper
    {
        public static TruckDTO MapToDTO(this Truck truck)
        {
            return new TruckDTO
            {
                VehicleBrandModel = truck.VehicleBrandModel,
                VehicleType = truck.VehicleType,
                LicencePlate = truck.LicencePlate,
                TotalDriven = truck.TotalDriven,
                MaxLoad = truck.MaxLoad
            };
        }

        public static Truck MapToModel(this TruckDTO truckDTO)
        {
            return new Truck(
                truckDTO.VehicleBrandModel,
                truckDTO.VehicleType,
                truckDTO.LicencePlate,
                truckDTO.MaxLoad
                );
        }
    }
}
