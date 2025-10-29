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

            if (transport is TaxiRequest taxiRequest)
            {
                TaxiRequestDTO taxiRequestDTO = TaxiRequestMapper.MapToDTO(taxiRequest);
                transportRepository.AddTaxiTransport(taxiRequestDTO, pickupAddressId, destinationAddressId);
            }
            else if (transport is CargoRequest cargoRequest)
            {
                CargoRequestDTO cargoRequestDTO = CargoRequestMapper.MapToDTO(cargoRequest);
                transportRepository.AddCargoTransport(cargoRequestDTO, pickupAddressId, destinationAddressId);
            }

        }

        public List<TransportRequest> GetTransportRequests()
        {
            List<TransportDTO> transportDTOs = transportRepository.GetTransports();
            List<TransportRequest> transportRequests = new List<TransportRequest>();

            foreach (TransportDTO transportDTO in transportDTOs)
            {
                if (transportDTO is CargoRequestDTO cargoRequestDTO)
                {
                    CargoRequest cargoRequestModel = CargoRequestMapper.MapToModel(cargoRequestDTO);
                    transportRequests.Add(cargoRequestModel);
                }
                else if (transportDTO is TaxiRequestDTO taxiRequestDTO)
                {
                    TaxiRequest taxiRequestModel = TaxiRequestMapper.MapToModel(taxiRequestDTO);
                    transportRequests.Add(taxiRequestModel);
                }
            }
            return transportRequests;
        }

    }
}