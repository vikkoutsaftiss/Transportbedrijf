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
                taxiRequestModel.PassengerCount,
                taxiRequestModel.TransportDistance,
                taxiRequestModel.TransportStatus
                );
        }
    

    public static TaxiRequestModel MapToModel(this TaxiRequest taxiRequest)
        {
            return new TaxiRequestModel
            {
                PickupAddress = taxiRequest.PickUpAddress.MapToModel(),
                DestinationAddress = taxiRequest.DestinationAddress.MapToModel(),
                DateTime = taxiRequest.DateTime,
                TransportType = taxiRequest.TransportType,
                PassengerCount = taxiRequest.PassengerCount,
                TransportDistance = taxiRequest.TransportDistance,
                TransportStatus = taxiRequest.TransportStatus
            };
        }
    }
}
