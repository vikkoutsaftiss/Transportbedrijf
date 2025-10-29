using Core.Domain.Models.Transport;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Mappers
{
    public static class TaxiRequestMapper
    {
        public static TaxiRequestDTO MapToDTO(this TaxiRequest taxiRequest)
        {
            return new TaxiRequestDTO
            {
                PickupAddress = taxiRequest.PickUpAddress.MapToDTO(),
                DestinationAddress = taxiRequest.DestinationAddress.MapToDTO(),
                TransportDateTime = taxiRequest.DateTime,
                TransportType = taxiRequest.TransportType,
                TransportStatus = taxiRequest.TransportStatus,
                TransportDistance = taxiRequest.TransportDistance,
                PassengerCount = taxiRequest.PassengerCount
            };
        }

        public static TaxiRequest MapToModel(this TaxiRequestDTO taxiRequestDTO)
        {
            return new TaxiRequest(
                taxiRequestDTO.PickupAddress.Map(),
                taxiRequestDTO.DestinationAddress.Map(),
                taxiRequestDTO.TransportDateTime,
                taxiRequestDTO.TransportType,
                taxiRequestDTO.PassengerCount
                );
        }
    }
}
