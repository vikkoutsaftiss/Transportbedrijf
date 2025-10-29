using Core.Domain.Models.AddressClass;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Helpers.Mappers
{
    public static class AddressMapper
    {
        public static Address Map(this AddressModel addressModel)
        {
            return new Address(
                addressModel.StreetAndNumber,
                addressModel.PostalCode,
                addressModel.City,
                addressModel.Country,
                addressModel.Longitude,
                addressModel.Latitude
                );
        }

        public static AddressModel MapToModel(this Address address)
        {
            return new AddressModel
            {
                StreetAndNumber = address.StreetWithNumber,
                PostalCode = address.PostalCode,
                City = address.City,
                Country = address.Country,
                Longitude = address.Longitude,
                Latitude = address.Latitude
            };
        }

    }
}
