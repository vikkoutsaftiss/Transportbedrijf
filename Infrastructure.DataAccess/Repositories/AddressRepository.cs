using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories
{
    public class AddressRepository
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=100.77.225.128;Database=TransporTDB;UserId=Vik;Password=H1209mysql!;");

        public AddressDTO GetAddressByID(int addressId)
        {
            AddressDTO address = new AddressDTO();
            int id = addressId;

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.addresses;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (id == Convert.ToInt32(reader["addressid"]))
                        {
                            address.Id = Convert.ToInt32(reader["addressid"]);
                            address.StreetWithNumber = reader["streetwithnumber"].ToString();
                            address.PostalCode = reader["postalcode"].ToString();
                            address.City = reader["city"].ToString();
                            address.Country = reader["country"].ToString();
                            address.Latitude = Convert.ToDouble(reader["latitude"]);
                            address.Longitude = Convert.ToDouble(reader["longitude"]);
                        }
                    }
                    sqlConnection.Close();
                    return address;
                }
            }
        }

        public int AddAddress(AddressDTO addressDTO)
        {
            string query = "INSERT INTO addresses (streetWithNumber, postalCode, city, country, latitude, longitude) VALUES (@streetwithnumber, @postalcode, @city, @country, @latitude, @longitude); SELECT LAST_INSERT_ID();";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("streetWithNumber", addressDTO.StreetWithNumber);
                cmd.Parameters.AddWithValue("postalCode", addressDTO.PostalCode);
                cmd.Parameters.AddWithValue("city", addressDTO.City);
                cmd.Parameters.AddWithValue("country", addressDTO.Country);
                cmd.Parameters.AddWithValue("latitude", addressDTO.Latitude);
                cmd.Parameters.AddWithValue("longitude", addressDTO.Longitude);

                object result = cmd.ExecuteScalar();
                sqlConnection.Close();

                int newAddressId = Convert.ToInt32(result);
                return newAddressId;
            }

        }
    }
}
