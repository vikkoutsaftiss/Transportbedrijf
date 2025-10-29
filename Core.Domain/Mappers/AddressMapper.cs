using Core.Domain.Models.AddressClass;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Mappers
{
    public static class AddressMapper
    {
        public static AddressDTO MapToDTO(this Address address)
        {
            return new AddressDTO
            {
                StreetWithNumber = address.StreetWithNumber,
                PostalCode = address.PostalCode,
                City = address.City,
                Country = address.Country,
                Longitude = address.Longitude,
                Latitude = address.Latitude
            };
        }

        public static Address Map(this AddressDTO addressDTO)
        {
            return new Address(
                addressDTO.StreetWithNumber,
                addressDTO.PostalCode,
                addressDTO.City,
                addressDTO.Country,
                addressDTO.Latitude,
                addressDTO.Longitude
                );
        }
    }
}
