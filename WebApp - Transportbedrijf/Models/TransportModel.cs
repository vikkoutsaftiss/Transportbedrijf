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
        public decimal TransportDistance { get; set; }
        public TransportStatus TransportStatus { get; set; }
        


    }
}
