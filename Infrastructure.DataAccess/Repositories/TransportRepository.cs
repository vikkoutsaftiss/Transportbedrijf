using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using TransporT.Shared.Enums;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using TransporT.Shared.Enums;



namespace Infrastructure.DataAccess.Repositories
{
    public class TransportRepository
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=100.77.225.128;Database=TransporTDB;UserId=Vik;Password=H1209mysql!;");

        

        public List<TransportDTO> GetTransports()
        {
            List<TransportDTO> transportDTOs = new List<TransportDTO>();

            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.transport;", sqlConnection))
            {
                sqlConnection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransportType transportType = (TransportType)Enum.Parse(typeof(TransportType), reader["transporttype"].ToString(), true);

                        TransportDTO transportDTO;

                        if (transportType == TransportType.Cargo)
                        {
                            CargoRequestDTO cargoRequestDTO = new CargoRequestDTO();
                            cargoRequestDTO.TransportWeight = Convert.ToInt32(reader["cargoweight"]);
                            transportDTO = cargoRequestDTO;
                        }
                        else if (transportType == TransportType.Passenger)
                        {
                            TaxiRequestDTO taxiRequestDTO = new TaxiRequestDTO();
                            taxiRequestDTO.PassengerCount = Convert.ToInt32(reader["passengercount"]);
                            transportDTO = taxiRequestDTO;
                        }
                        else
                        {
                             transportDTO = new TransportDTO();
                        }


                        transportDTO.Id = Convert.ToInt32(reader["transportid"]);
                        transportDTO.TransportDateTime = (DateTime)reader["transportdatetime"];
                        transportDTO.TransportType = transportType;
                        transportDTO.TransportStatus = (TransportStatus)Enum.Parse(typeof(TransportStatus), reader["transportstatus"].ToString(), true);
                        transportDTO.TransportDistance = Convert.ToInt32(reader["transportdistance"]);

                        int pickupAddressID = Convert.ToInt32(reader["pickupaddressid"]);
                        AddressRepository addressRepository = new AddressRepository();
                        AddressDTO pickupAddress = addressRepository.GetAddressByID(pickupAddressID);
                        transportDTO.PickupAddress = pickupAddress;

                        int destinationAddressID = Convert.ToInt32(reader["destinationaddressid"]);
                        AddressDTO destinationAddress = addressRepository.GetAddressByID(destinationAddressID);
                        transportDTO.DestinationAddress = destinationAddress;


                        object driverIdValue = reader["driverid"];
                        if (driverIdValue != DBNull.Value)
                        {
                            int driverid = Convert.ToInt32(reader["driverid"]);
                            DriverRepository driverRepository = new DriverRepository();
                            DriverDTO driver = driverRepository.GetDriverByID(driverid);
                            transportDTO.Driver = driver;
                        }
                        else
                        {
                            transportDTO.Driver = null;
                        }

                        object vehicleIdValue = reader["vehicleid"];
                        if (vehicleIdValue != DBNull.Value)
                        {
                            int vehicleId = Convert.ToInt32(reader["vehicleid"]);
                            VehicleRepository vehicleRepository = new VehicleRepository();
                            VehicleDTO vehicle = vehicleRepository.GetVehicleByID(vehicleId);
                            transportDTO.Vehicle = vehicle;
                        }
                        else
                        {
                            transportDTO.Vehicle = null;
                        }

                        transportDTOs.Add(transportDTO);
                    }
                }
            }
            return transportDTOs;
        }

        

        

        public void AddTaxiTransport(TaxiRequestDTO taxiRequestDTO, int pickupAddressId, int destinationAddressId)
        {
            string query = "INSERT INTO transport (transportType, pickupAddressId, destinationAddressId, transportDateTime, passengerCount) VALUES (@transportType, @pickupAddressid, @destinationAddressid, @DateTime, @passengerCount)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                AddTransport(cmd, taxiRequestDTO, pickupAddressId, destinationAddressId, query);
                cmd.Parameters.AddWithValue("@passengerCount", taxiRequestDTO.PassengerCount);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();


            }
        }

        public void AddCargoTransport(CargoRequestDTO cargoRequestDTO, int pickupAddressId, int destinationAddressId)
        {
            string query = "INSERT INTO transport (transportType, pickupAddressId, destinationAddressId, transportDateTime, cargoWeight) VALUES (@transportType, @pickupAddressid, @destinationAddressid, @DateTime, @transportWeight)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                AddTransport(cmd, cargoRequestDTO, pickupAddressId, destinationAddressId, query);
                cmd.Parameters.AddWithValue("@transportWeight", cargoRequestDTO.TransportWeight);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        
        private void AddTransport(MySqlCommand cmd, TransportDTO transportDTO, int pickupAddressId, int destinationAddressId, string query)
        {            
            cmd.Parameters.AddWithValue("@transportType", transportDTO.TransportType.ToString());
            cmd.Parameters.AddWithValue("@pickupAddressId", pickupAddressId);
            cmd.Parameters.AddWithValue("@destinationAddressId", destinationAddressId);
            cmd.Parameters.AddWithValue("@DateTime", transportDTO.TransportDateTime);            
        }
    }
}