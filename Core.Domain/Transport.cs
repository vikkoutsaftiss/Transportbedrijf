namespace Core.Domain
{
    public class Transport
    {
        private string _pickUpAddress;
        private string _destinationAddress;
        private DateTime _transportDateTime;
        private Vehicle _vehicle;
        private Driver _driver;
        private int _transportWeight;


        public string PickUpAddress { get { return _pickUpAddress; } }
        public string DestinationAddress { get { return _destinationAddress; } }
        public DateTime DateTime { get { return _transportDateTime; } }
        public Vehicle Vehicle { get { return _vehicle; } }
        public Driver Driver { get { return _driver; } }
        public int TransportWeight { get { return _transportWeight; } }
        

        public Transport(string pickUpAddress, string destinationAddress, DateTime dateTime, Vehicle vehicle, Driver driver, int transportWeight)
        {
            _pickUpAddress = pickUpAddress;
            _destinationAddress = destinationAddress;
            _transportDateTime = dateTime;
            _vehicle = vehicle;
            _driver = driver;
            _transportWeight = transportWeight;
        }
    }
}
