using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Models.AddressClass
{
    public class Address
    {
        private int _Id;
        private string _streetWithNumber;
        private string _postalCode;
        private string _city;
        private string _country;

        private double _latitude;
        private double _longitude;

        public int? Id { get { return _Id; } }
        public string StreetWithNumber { get { return _streetWithNumber; } }
        public string PostalCode { get { return _postalCode; } }
        public string City { get { return _city; } }
        public string Country { get { return _country; } }

        public double Latitude { get { return _latitude; } }
        public double Longitude { get { return _longitude; } }

        public Address(int id, string streetWithNumber, string postalCode, string city, string country, double latitude, double longitude)
        {
            _streetWithNumber = streetWithNumber;
            _postalCode = postalCode;
            _city = city;
            _country = country;
            _latitude = latitude;
            _longitude = longitude;
        }

        public Address(string streetWithNumber, string postalCode, string city, string country, double latitude, double longitude)
        {
            _streetWithNumber = streetWithNumber;
            _postalCode = postalCode;
            _city = city;
            _country = country;
            _latitude = latitude;
            _longitude = longitude;
        }
    }
}
