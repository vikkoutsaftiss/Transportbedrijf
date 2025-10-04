namespace Infrastructure.DataAccess.DTO
{
    public class TransportDTO
    {
        public string PickupAddress { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime TransportDateTime {  get; set; }
        public VehicleDTO Vehicle { get; set; }
        public string Driver { get; set; } //object driver aangepast naar string Driver
        public string TransportType { get; set; } //object TransportType aangepast naar string TransportType
        public int? TransportWeight { get; set; }
        public int? PassengerCount { get; set; }      
    }
}
