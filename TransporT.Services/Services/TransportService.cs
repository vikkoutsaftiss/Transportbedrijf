using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Models.Transport;

namespace TransporT.Services.Services
{
    public class TransportService
    {
        public void AddTransport(TransportRequest transport)
        {
            TransportRepository transportRepository = new TransportRepository();

            AddressDTO pickUpaddressDTO = new AddressDTO()
            {
                StreetWithNumber = transport.PickUpAddress.StreetWithNumber,
                PostalCode = transport.PickUpAddress.PostalCode,
                City = transport.PickUpAddress.City,
                Country = transport.PickUpAddress.Country,
                Latitude = transport.PickUpAddress.Latitude,
                Longitude = transport.PickUpAddress.Longitude
            };

            AddressDTO destinationAddressDTO = new AddressDTO()
            {
                StreetWithNumber = transport.DestinationAddress.StreetWithNumber,
                PostalCode = transport.DestinationAddress.PostalCode,
                City = transport.DestinationAddress.City,
                Country = transport.DestinationAddress.Country,
                Latitude = transport.DestinationAddress.Latitude,
                Longitude = transport.DestinationAddress.Longitude
            };

            transportRepository.AddTransport(new TransportDTO()
            {
                PickupAddress = pickUpaddressDTO,
                DestinationAddress = destinationAddressDTO,
                TransportDateTime = transport.DateTime,
                TransportType = transport.TransportType,
                TransportDistance = transport.TransportDistance,
                TransportWeight = transport.TransportWeight,
                PassengerCount = transport.PassengerCount,
            });
    }


    }
}
