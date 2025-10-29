using Core.Domain.Models.Transport;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    public static class TaxiRequestMapper
    {
        public static TaxiRequest Map(this TaxiRequestModel taxiRequestModel)
        {
            return new TaxiRequest(
                taxiRequestModel.PickupAddress.Map(),
                taxiRequestModel.DestinationAddress.Map(),
                taxiRequestModel.DateTime,
                taxiRequestModel.TransportType,
                //transportModel.transportDistance,
                taxiRequestModel.PassengerCount);
        }
    }
}
