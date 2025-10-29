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
                //transportModel.transportDistance,
                cargoRequestModel.TransportWeight
                );
        }
    }
}
