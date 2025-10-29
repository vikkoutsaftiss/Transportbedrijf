using Core.Domain.Models.Transport;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    public static class CargoRequestMapper
    {
        public static CargoRequest Map(this CargoRequestModel cargoRequestModel)
        {
            return new CargoRequest(
                cargoRequestModel.PickupAddress.Map(),
                cargoRequestModel.DestinationAddress.Map(),
                cargoRequestModel.DateTime,
                cargoRequestModel.TransportType,
                cargoRequestModel.TransportDistance,
                cargoRequestModel.TransportWeight
                );
        }

        public static CargoRequestModel MapToModel(this CargoRequest cargoRequest)
        {
            return new CargoRequestModel
            {
                PickupAddress = cargoRequest.PickUpAddress.MapToModel(),
                DestinationAddress = cargoRequest.DestinationAddress.MapToModel(),
                DateTime = cargoRequest.DateTime,
                TransportType = cargoRequest.TransportType,
                TransportWeight = cargoRequest.TransportWeight,
                TransportDistance = cargoRequest.TransportDistance
            };
        }

       
    }
}