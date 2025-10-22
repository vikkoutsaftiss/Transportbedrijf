using Core.Domain.Mappers;
using Core.Domain.Models.Transport;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporT.Services.Services
{
    public class TransportService
    {
        AddressRepository addressRepository = new AddressRepository();
        TransportRepository transportRepository = new TransportRepository();

        public void AddTransport(TransportRequest transport)
        {

            AddressDTO pickUpaddressDTO = AddressMapper.MapToDTO(transport.PickUpAddress);
            AddressDTO destinationAddressDTO = AddressMapper.MapToDTO(transport.DestinationAddress);

            int pickupAddressId = addressRepository.AddAddress(pickUpaddressDTO);
            int destinationAddressId = addressRepository.AddAddress(destinationAddressDTO);



            TransportDTO transportDTO = TransportMapper.MapToDTO(transport);

            transportRepository.AddTransport(transportDTO, pickupAddressId, destinationAddressId);
    }


    }
}
