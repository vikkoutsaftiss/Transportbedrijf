using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess.DTO;
using TransporT.Shared.Enums;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    internal static class TaxiMapper
    {
        public static Taxi Map(this TaxiModel taxiModel)
        {
            return new Taxi(
                taxiModel.VehicleBrandModel,
                (VehicleType)taxiModel.VehicleType,
                taxiModel.LicencePlate,
                taxiModel.MaxPersons
                );
        }

        public static TaxiModel MapToModel(this Taxi taxi)
        {
            return new TaxiModel
            {
                VehicleBrandModel = taxi.VehicleBrandModel,
                VehicleType = (VehicleTypeModel)taxi.VehicleType,
                LicencePlate = taxi.LicencePlate,
                TotalDriven = taxi.TotalDriven,
                MaxPersons = taxi.MaxPersons
            };
        }


    }

        
}

