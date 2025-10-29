using Core.Domain.Models.Transport;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Mappers
{
    public static class CargoRequestMapper
    {
        public static CargoRequestDTO MapToDTO(this CargoRequest cargoRequest)
        {
            return new CargoRequestDTO
            {
                PickupAddress = cargoRequest.PickUpAddress.MapToDTO(),
                DestinationAddress = cargoRequest.DestinationAddress.MapToDTO(),
                TransportDateTime = cargoRequest.DateTime,
                TransportType = cargoRequest.TransportType,
                TransportStatus = cargoRequest.TransportStatus,
                TransportDistance = cargoRequest.TransportDistance,
                TransportWeight = cargoRequest.TransportWeight,
            };
        }

        public static CargoRequest MapToModel(this CargoRequestDTO cargoRequestDTO)
        {
            return new CargoRequest(
                cargoRequestDTO.PickupAddress.Map(),
                cargoRequestDTO.DestinationAddress.Map(),
                cargoRequestDTO.TransportDateTime,
                cargoRequestDTO.TransportType,
                cargoRequestDTO.TransportDistance,
                cargoRequestDTO.TransportWeight                
                );
        }
    }
}
