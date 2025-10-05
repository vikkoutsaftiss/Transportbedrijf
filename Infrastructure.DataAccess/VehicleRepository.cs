using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class VehicleRepository
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=100.77.225.128;Database=TransporTDB;UserId=Vik;Password=H1209mysql!;");

        public List<VehicleDTO> GetVehicles()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>();

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.vehicle;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VehicleDTO vehicle = new VehicleDTO();
                        {
                            vehicle.Id = Convert.ToInt32(reader["vehicleid"]);
                            vehicle.VehicleBrandModel = reader["vehiclebrandmodel"].ToString();
                            vehicle.VehicleType = Convert.ToInt32(reader["type"]);
                            vehicle.TotalDriven = Convert.ToInt32(reader["totaldriven"]);
                            vehicle.MaxLoad = reader.IsDBNull(reader.GetOrdinal("maxload"))
                                              ? (int?)null
                                              : reader.GetInt32(reader.GetOrdinal("maxload"));
                            vehicle.MaxPersons = reader.IsDBNull(reader.GetOrdinal("maxpersons"))
                                              ? (int?)null
                                              : reader.GetInt32(reader.GetOrdinal("maxpersons"));
                            vehicles.Add(vehicle);
                        }
                    }
                }
                sqlConnection.Close();
                return vehicles;
            }
        }

        public void AddVehicle(VehicleDTO vehicleDTO)
        {
            string query = "INSERT INTO vehicle (vehicleBrandModel, type, TotalDriven, maxLoad, maxPersons) VALUES (@vehicleBrandModel, @type, @TotalDriven, @maxLoad, @maxPersons)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@vehicleBrandModel", vehicleDTO.VehicleBrandModel);
                cmd.Parameters.AddWithValue("@type", vehicleDTO.VehicleType);
                cmd.Parameters.AddWithValue("@TotalDriven", vehicleDTO.TotalDriven);
                cmd.Parameters.AddWithValue("@maxLoad", vehicleDTO.MaxLoad);
                cmd.Parameters.AddWithValue("@maxPersons", vehicleDTO.MaxPersons);

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
    }
}
