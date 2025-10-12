using Core.Domain;
using Infrastructure.DataAccess.DTO;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    internal static class TruckMapper
    {
        public static Truck Map(this TruckModel truckModel)
        {
            return new Truck(
                truckModel.VehicleBrandModel,
                (Core.Domain.VehicleType)truckModel.VehicleType,
                truckModel.LicencePlate,
                truckModel.MaxLoad
                );
        }

        public static TruckModel MapToModel(this TruckDTO truckDTO)
        {
            return new TruckModel
            {
                VehicleBrandModel = truckDTO.VehicleBrandModel,
                VehicleType = (VehicleTypeModel)truckDTO.VehicleType,
                LicencePlate = truckDTO.LicencePlate,
                TotalDriven = truckDTO.TotalDriven,
                MaxLoad = truckDTO.MaxLoad
            };
        }
    }
}
