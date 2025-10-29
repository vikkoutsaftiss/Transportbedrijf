using Core.Domain.Models.AddressClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Enums;

namespace Core.Domain.Models.Transport
{
    public class CargoRequest : TransportRequest
    {
        private int _transportWeight;

        public int TransportWeight { get { return _transportWeight; }}

        public CargoRequest(Address pickUpAddress, Address destinationAddress, DateTime dateTime, TransportType transportType, decimal transportDistance, int transportWeight)
            : base(pickUpAddress, destinationAddress, dateTime, transportType, transportDistance)
        {
            _transportWeight = transportWeight;
        }

    }
}
