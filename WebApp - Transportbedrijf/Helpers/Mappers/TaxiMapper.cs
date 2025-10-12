using Core.Domain;
using Infrastructure.DataAccess.DTO;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    internal static class TaxiMapper
    {
        public static Taxi Map(this TaxiModel taxiModel)
        {
            return new Taxi(
                taxiModel.VehicleBrandModel,
                (Core.Domain.VehicleType)taxiModel.VehicleType,
                taxiModel.LicencePlate,
                taxiModel.MaxPersons
                );
        }

        public static TaxiModel MapToModel(this TaxiDTO taxiDTO)
        {
            return new TaxiModel
            {
                VehicleBrandModel = taxiDTO.VehicleBrandModel,
                VehicleType = (VehicleTypeModel)taxiDTO.VehicleType,
                LicencePlate = taxiDTO.LicencePlate,
                TotalDriven = taxiDTO.TotalDriven,
                MaxPersons = taxiDTO.MaxPersons
            };
        }
                
            
    }

        
}

