namespace Infrastructure.DataAccess.DTO
{
    public class TransportDTO
    {
        public int ID { get; set; }
        public string PickupAddress { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime TransportDateTime {  get; set; }
        public VehicleDTO Vehicle { get; set; }
        public int TransportType { get; set; }
        public int TransportStatus { get; set; }
        public DriverDTO Driver { get; set; } //object driver aangepast naar string Driver
        public int? TransportWeight { get; set; }
        public int? PassengerCount { get; set; }      
    }
}
