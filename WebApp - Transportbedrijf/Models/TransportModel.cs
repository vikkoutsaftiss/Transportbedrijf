using System.ComponentModel.DataAnnotations;
using TransporT.Shared.Enums;

namespace WebApp___Transportbedrijf.Models
{
    public class TransportModel
    {
        public AddressModel PickupAddress { get; set; }
        public AddressModel DestinationAddress { get; set; }
        public DateTime DateTime { get; set; }
        public TransportType TransportType { get; set; }
        public int transportDistance { get; set; }
        public int? TransportWeight { get; set; }
        public int? PassengerCount { get; set; }


    }
}
