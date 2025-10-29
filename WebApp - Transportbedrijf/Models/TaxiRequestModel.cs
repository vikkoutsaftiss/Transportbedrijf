using TransporT.Shared.Enums;

namespace WebApp___Transportbedrijf.Models
{
    public class TaxiRequestModel
    {
        public AddressModel PickupAddress { get; set; }
        public AddressModel DestinationAddress { get; set; }
        public DateTime DateTime { get; set; }
        public TransportType TransportType { get; set; }
        public int TransportDistance { get; set; }
        public int PassengerCount { get; set; }
    }
}
