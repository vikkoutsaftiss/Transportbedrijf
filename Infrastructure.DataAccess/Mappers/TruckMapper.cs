using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Models.Vehicles;

namespace Infrastructure.DataAccess.Mappers
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
    }
}
