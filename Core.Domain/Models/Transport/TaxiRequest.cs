using Core.Domain.Models.AddressClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Enums;

namespace Core.Domain.Models.Transport
{
    public class TaxiRequest : TransportRequest
    {
        private int _passengerCount;

        public int PassengerCount { get { return _passengerCount; }}

        public TaxiRequest(Address pickUpAddress, Address destinationAddress, DateTime dateTime, TransportType transportType, int passengerCount, decimal transportDistance, TransportStatus transportStatus)
            : base(pickUpAddress, destinationAddress, dateTime, transportType, transportDistance, transportStatus)
        {
            _passengerCount = passengerCount;
            
        }

    }
}
