using Core.Domain;

namespace Infrastructure.DataAccess.DTO
{
    public class TransportDTO
    {
        public string PickupAddress { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime TransportDateTime {  get; set; }
        public VehicleDTO Vehicle { get; set; }
        public Driver Driver { get; set; }
        public TransportType TransportType { get; set; }
        public int? TransportWeight { get; set; }
        public int? PassengerCount { get; set; }      
    }
}
