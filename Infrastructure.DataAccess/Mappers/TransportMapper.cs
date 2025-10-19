using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared;
using TransporT.Shared.Models.Transport;

namespace Infrastructure.DataAccess.Mappers
{
    public static class TransportMapper
    {
        public static TransportDTO MapToDTO(this TransportRequest transportRequest)
        {
            return new TransportDTO
            {
                PickupAddress = transportRequest.PickUpAddress.MapToDTO(),
                DestinationAddress = transportRequest.DestinationAddress.MapToDTO(),
                TransportDateTime = transportRequest.DateTime,
                TransportType = transportRequest.TransportType,
                TransportStatus = transportRequest.TransportStatus,
                TransportDistance = transportRequest.TransportDistance,
                TransportWeight = transportRequest.TransportWeight,
                PassengerCount = transportRequest.PassengerCount
            };
        }


    }
}
