namespace Core.Domain
{
    public class Transport
    {
        private string _pickUpAddress;
        private string _destinationAddress;
        private DateTime _transportDateTime;
        private Vehicle _vehicle;
        private Driver _driver;
        private TransportType _transportType;
        private int? _transportWeight;
        private int? _passengerCount;


        public string PickUpAddress { get { return _pickUpAddress; } }
        public string DestinationAddress { get { return _destinationAddress; } }
        public DateTime DateTime { get { return _transportDateTime; } }
        public Vehicle Vehicle { get { return _vehicle; } }
        public Driver Driver { get { return _driver; } }
        public TransportType TransportType { get { return _transportType; } }
        public int? TransportWeight { get { return _transportWeight; } }
        public int? PassengerCount { get { return _passengerCount; } }


        public Transport(string pickUpAddress, string destinationAddress, DateTime dateTime, Vehicle vehicle, Driver driver, TransportType transportType, int? transportWeight = null, int? passengerCount = null)
        {
            _pickUpAddress = pickUpAddress;
            _destinationAddress = destinationAddress;
            _transportDateTime = dateTime;
            _vehicle = vehicle;
            _driver = driver;
            _transportType = transportType;

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

        //        public Transport(string pickUpAddress, string destinationAddress, DateTime dateTime, Vehicle vehicle, Driver driver, int passengerCount)
        //        {
        //            _pickUpAddress = pickUpAddress;
        //            _destinationAddress = destinationAddress;
        //            _transportDateTime = dateTime;
        //            _vehicle = vehicle;
        //            _driver = driver;
        //            _passengerCount = passengerCount;
        //            _transportWeight = null;
        //            _transportType = TransportType.Passenger;
        //        }

        public bool TryStart()
        {
            if ((PassengerCount != null && TransportType == TransportType.Passenger) || (TransportWeight != null && TransportType == TransportType.Cargo))
            {
                if (TransportType == TransportType.Cargo)
                {
                    if (Vehicle.MaxLoad >= TransportWeight)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (TransportType == TransportType.Passenger)
                {
                    if (Vehicle.MaxPersons >= PassengerCount)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            return false;
        }
    }
}
