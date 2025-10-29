using Core.Domain.Models.AddressClass;
using Core.Domain.Models.Vehicles;
using TransporT.Shared.Enums;
using TransporT.Shared.Models.Employees;

namespace Core.Domain.Models.Transport
{
    public class TransportRequest
    {
        private int _Id;
        private Address _pickUpAddress;
        private Address _destinationAddress;
        private DateTime _transportDateTime;
        private Vehicle _vehicle;
        private Driver _driver;
        private TransportType _transportType;
        private TransportStatus _transportStatus;
        private int _transportDistance;

        public int Id { get { return _Id; } }
        public Address PickUpAddress { get { return _pickUpAddress; } }
        public Address DestinationAddress { get { return _destinationAddress; } }
        public DateTime DateTime { get { return _transportDateTime; } }
        public Vehicle Vehicle { get { return _vehicle; } }
        public Driver Driver { get { return _driver; } }
        public TransportType TransportType { get { return _transportType; } }
        public TransportStatus TransportStatus { get { return _transportStatus; } }
        public int TransportDistance { get { return _transportDistance; } }


        public TransportRequest(Address pickUpAddress, Address destinationAddress, DateTime dateTime, TransportType transportType)
        {
            _pickUpAddress = pickUpAddress;
            _destinationAddress = destinationAddress;
            _transportDateTime = dateTime;
            _transportType = transportType;
            _transportStatus = TransportStatus.Pending;
        }

    }
}
