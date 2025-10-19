using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Models;
using TransporT.Shared.Models.AddressClass;

namespace Infrastructure.DataAccess.Mappers
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
    }
}
