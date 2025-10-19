using Infrastructure.DataAccess.DTO;
using TransporT.Shared.Enums;
using TransporT.Shared.Models.Vehicles;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    internal static class TruckMapper
    {
        public static Truck Map(this TruckModel truckModel)
        {
            return new Truck(
                truckModel.VehicleBrandModel,
                (VehicleType)truckModel.VehicleType,
                truckModel.LicencePlate,
                truckModel.MaxLoad
                );
        }

        public static TruckModel MapToModel(this Truck truck)
        {
            return new TruckModel
            {
                VehicleBrandModel = truck.VehicleBrandModel,
                VehicleType = (VehicleTypeModel)truck.VehicleType,
                LicencePlate = truck.LicencePlate,
                TotalDriven = truck.TotalDriven,
                MaxLoad = truck.MaxLoad
            };
        }

       
    }
}
