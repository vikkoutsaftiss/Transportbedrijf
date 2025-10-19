using System.Net.NetworkInformation;
using TransporT.Shared;
using TransporT.Shared.Models.Transport;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    public static class TransportMapper
    {
        public static TransportRequest Map(this TransportModel transportModel)
        {
            return new TransportRequest(
                transportModel.PickupAddress.Map(),
                transportModel.DestinationAddress.Map(),
                transportModel.DateTime,
                transportModel.TransportType,
                //transportModel.transportDistance,
                transportModel.TransportWeight,
                transportModel.PassengerCount);
        }

        
    }
}
