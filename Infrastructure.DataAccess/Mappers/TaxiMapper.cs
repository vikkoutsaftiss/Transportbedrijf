using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Models.Vehicles;

namespace Infrastructure.DataAccess.Mappers
{
    public static class TaxiMapper
    {
        public static TaxiDTO MapToDTO(this Taxi taxi)
        {
            return new TaxiDTO
            {
                VehicleBrandModel = taxi.VehicleBrandModel,
                VehicleType = taxi.VehicleType,
                LicencePlate = taxi.LicencePlate,
                TotalDriven = taxi.TotalDriven,
                MaxPersons = taxi.MaxPersons
            };
        }
    }
}
