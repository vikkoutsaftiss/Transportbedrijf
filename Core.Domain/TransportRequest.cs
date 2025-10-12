namespace Core.Domain
{
    public class TransportRequest
    {
        private string _pickUpAddress;
        private string _destinationAddress;
        private DateTime _transportDateTime;
        private Vehicle _vehicle;
        private Driver _driver;
        private TransportType _transportType;
        private TransportStatus _transportStatus;
        private int? _transportWeight;
        private int? _passengerCount;


        public string PickUpAddress { get { return _pickUpAddress; } }
        public string DestinationAddress { get { return _destinationAddress; } }
        public DateTime DateTime { get { return _transportDateTime; } }
        public Vehicle Vehicle { get { return _vehicle; } }
        public Driver Driver { get { return _driver; } }
        public TransportType TransportType { get { return _transportType; } }
        public TransportStatus TransportStatus { get { return _transportStatus; } }
        public int? TransportWeight { get { return _transportWeight; } }
        public int? PassengerCount { get { return _passengerCount; } }


        public TransportRequest(string pickUpAddress, string destinationAddress, DateTime dateTime, TransportType transportType, int? transportWeight = null, int? passengerCount = null)
        {
            _pickUpAddress = pickUpAddress;
            _destinationAddress = destinationAddress;
            _transportDateTime = dateTime;
            _transportType = transportType;
            _transportStatus = TransportStatus.Pending;

            if (transportWeight.HasValue)
            {
                _transportWeight = transportWeight;
            }
            else if (passengerCount.HasValue)
            {
                _passengerCount = passengerCount;
            }

            //ToDo: toevoegen aan list.


        }

    }
}
