using TransporT.Shared.Enums;

namespace Infrastructure.DataAccess.DTO
{
    public class TransportDTO
    {
        public int Id { get; set; }
        public AddressDTO PickupAddress { get; set; }
        public AddressDTO DestinationAddress { get; set; }
        public DateTime TransportDateTime { get; set; }
        public VehicleDTO Vehicle { get; set; }
        public TransportType TransportType { get; set; }
        public TransportStatus TransportStatus { get; set; }
        public DriverDTO Driver { get; set; }
        public int TransportDistance { get; set; }

    }
}

