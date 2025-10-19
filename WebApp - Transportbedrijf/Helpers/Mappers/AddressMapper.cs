using TransporT.Shared.Models.AddressClass;
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

    }
}
