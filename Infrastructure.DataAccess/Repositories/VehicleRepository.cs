using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Enums;

namespace Infrastructure.DataAccess.Repositories
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
                        int typeId = Convert.ToInt32(reader["type"]);

                        VehicleDTO vehicle;

                        if (typeId == 1)
                        {
                            TaxiDTO taxi = new TaxiDTO();
                            taxi.MaxPersons = Convert.ToInt32(reader["maxpersons"]);

                            vehicle = taxi;
                        }
                        else if (typeId == 0)
                        {
                            TruckDTO truck = new TruckDTO();
                            truck.MaxLoad = Convert.ToInt32(reader["maxload"]);

                            vehicle = truck;
                        }
                        else
                        {
                            vehicle = new VehicleDTO();
                        }

                        vehicle.Id = Convert.ToInt32(reader["vehicleid"]);
                        vehicle.VehicleBrandModel = reader["vehiclebrandmodel"].ToString();
                        vehicle.VehicleType = (VehicleType)Convert.ToInt32(reader["type"]);
                        vehicle.TotalDriven = Convert.ToInt32(reader["totaldriven"]);
                        vehicle.LicencePlate = reader["licenceplate"].ToString();

                        vehicles.Add(vehicle);



                    }
                }
                sqlConnection.Close();
                return vehicles;
            }
        }

        public void AddVehicle(VehicleDTO vehicleDTO)
        {
            string query = "INSERT INTO vehicle (vehicleBrandModel, type, TotalDriven, maxLoad, maxPersons, licencePlate) VALUES (@vehicleBrandModel, @type, @TotalDriven, @maxLoad, @maxPersons, @licencePlate)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@vehicleBrandModel", vehicleDTO.VehicleBrandModel);
                cmd.Parameters.AddWithValue("@type", vehicleDTO.VehicleType);
                cmd.Parameters.AddWithValue("@TotalDriven", vehicleDTO.TotalDriven);
                cmd.Parameters.AddWithValue("@licencePlate", vehicleDTO.LicencePlate);

                if (vehicleDTO is TruckDTO truck)
                {
                    cmd.Parameters.AddWithValue("@maxLoad", truck.MaxLoad);
                    cmd.Parameters.AddWithValue("@maxPersons", DBNull.Value); // expliciet NULL maken
                }
                else if (vehicleDTO is TaxiDTO taxi)
                {
                    cmd.Parameters.AddWithValue("@maxPersons", taxi.MaxPersons);
                    cmd.Parameters.AddWithValue("@maxLoad", DBNull.Value); // expliciet NULL maken
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maxLoad", DBNull.Value);
                    cmd.Parameters.AddWithValue("@maxPersons", DBNull.Value);
                }

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public VehicleDTO GetVehicleByID(int vehicleid)
        {
            VehicleDTO vehicleDTO = new VehicleDTO();

            int id = vehicleid;

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.vehicle WHERE vehicleid = @id;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (id == Convert.ToInt32(reader["vehicleid"]))
                        {
                            vehicleDTO.Id = Convert.ToInt32(reader["vehicleid"]);
                            vehicleDTO.VehicleBrandModel = reader["vehiclebrandmodel"].ToString();
                            vehicleDTO.VehicleType = (VehicleType)Convert.ToInt32(reader["type"]);
                            vehicleDTO.TotalDriven = Convert.ToInt32(reader["totaldriven"]);
                            vehicleDTO.LicencePlate = reader["licenceplate"].ToString();
                        }

                    }
                }

            }
            sqlConnection.Close();
            return vehicleDTO;
        }
    }
}
