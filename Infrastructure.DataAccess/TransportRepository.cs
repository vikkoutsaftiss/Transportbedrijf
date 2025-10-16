using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;


namespace Infrastructure.DataAccess
{
    public class TransportRepository
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=100.77.225.128;Database=TransporTDB;UserId=Vik;Password=H1209mysql!;");

        public List<TransportDTO> GetTransports()
        {
            List<TransportDTO> transports = new List<TransportDTO>();

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.transport;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransportDTO transportDTO = new TransportDTO();
                        transportDTO.Id = Convert.ToInt32(reader["transportid"]);
                        transportDTO.PickupAddress = reader["pickupaddress"].ToString();
                        transportDTO.DestinationAddress = reader["destinationaddress"].ToString();
                        transportDTO.TransportDateTime = (DateTime)reader["transportdatetime"];
                        transportDTO.TransportType = Convert.ToInt32(reader["transporttype"]);
                        transportDTO.TransportStatus = Convert.ToInt32(reader["transportstatus"]);

                        int driverid = Convert.ToInt32(reader["driverid"]);
                        DriverRepository driverRepository = new DriverRepository();
                        DriverDTO driver = driverRepository.GetDriverByID(driverid);
                        transportDTO.Driver = driver;

                        int vehicleId = Convert.ToInt32(reader["vehicleid"]);
                        VehicleRepository vehicleRepository = new VehicleRepository();
                        VehicleDTO vehicle = vehicleRepository.GetVehicleByID(vehicleId);
                        transportDTO.Vehicle = vehicle;

                        if (vehicle.VehicleType == 0)
                        {
                            transportDTO.TransportWeight = Convert.ToInt32(reader["transportweight"]);
                        }
                        else if (vehicle.VehicleType == 1)
                        {
                            transportDTO.PassengerCount = Convert.ToInt32(reader["passengercount"]);
                        }

                        transports.Add(transportDTO);

                    }
                }
            }
            sqlConnection.Close();
            return transports;

        }

        public void AddTransport(TransportDTO transportDTO)
        {
            string query = "INSERT INTO transport (transportType, pickupAddress, destinationAddress, transportDateTime, transportPrice, cargoWeight, passengerCount) VALUES (@transportType, @pickupAddress, @destinationAddress, @DateTime, @transportPrice, @transportWeight, @passengerCount)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@transportType", transportDTO.TransportType);
                cmd.Parameters.AddWithValue("@pickupAddress", transportDTO.PickupAddress);
                cmd.Parameters.AddWithValue("@destinationAddress", transportDTO.DestinationAddress);
                cmd.Parameters.AddWithValue("@DateTime", transportDTO.TransportDateTime);
                //cmd.Parameters.AddWithValue("transportPrice", transportDTO.)
                cmd.Parameters.AddWithValue("@transportWeight", transportDTO.TransportWeight);
                cmd.Parameters.AddWithValue("passengerCount", transportDTO.PassengerCount);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

            }

        }
    }


}
