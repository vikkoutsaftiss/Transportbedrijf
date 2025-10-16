using System.ComponentModel.DataAnnotations;

namespace WebApp___Transportbedrijf.Models
{
    public class TransportModel
    {
        public AddressModel PickupAddress { get; set; }
        public AddressModel DestinationAddress { get; set; }
        public DateTime DateTime { get; set; }
        public TransportTypeModel TransportType { get; set; }
        public int transportDistance { get; set; }
        public int? TransportWeight { get; set; }
        public int? PassengerCount { get; set; }


    }
}
