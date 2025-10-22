using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Mappers
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

        public static Taxi MapToModel(this TaxiDTO taxiDTO)
        {
            return new Taxi(
                    taxiDTO.VehicleBrandModel,
                    taxiDTO.VehicleType,
                    taxiDTO.LicencePlate,
                    taxiDTO.MaxPersons
                    );
        }
    }
}
