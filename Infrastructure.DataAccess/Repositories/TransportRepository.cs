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
            List<TransportDTO> transports = new List<TransportDTO>();

            transports.AddRange(GetTaxiRequests());

            transports.AddRange(GetCargoRequests());


            return transports;
        }

        private List<TaxiRequestDTO> GetTaxiRequests()
        {
            List<TaxiRequestDTO> taxiRequestDTOs = new List<TaxiRequestDTO>();

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.transport;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaxiRequestDTO taxiRequestDTO = new TaxiRequestDTO();

                        taxiRequestDTO.Id = Convert.ToInt32(reader["transportid"]);
                        taxiRequestDTO.TransportDateTime = (DateTime)reader["transportdatetime"];
                        taxiRequestDTO.TransportType = (TransportType)Convert.ToInt32(reader["transporttype"]);
                        taxiRequestDTO.TransportStatus = (TransportStatus)Convert.ToInt32(reader["transportstatus"]);
                        taxiRequestDTO.PassengerCount = Convert.ToInt32(reader["passengercount"]);

                        int pickupAddressID = Convert.ToInt32(reader["pickupaddressid"]);
                        AddressRepository addressRepository = new AddressRepository();
                        AddressDTO pickupAddress = addressRepository.GetAddressByID(pickupAddressID);
                        taxiRequestDTO.PickupAddress = pickupAddress;

                        int destinationAddressID = Convert.ToInt32(reader["destinationaddressid"]);
                        AddressDTO destinationAddress = addressRepository.GetAddressByID(destinationAddressID);
                        taxiRequestDTO.PickupAddress = pickupAddress;

                        int driverid = Convert.ToInt32(reader["driverid"]);
                        DriverRepository driverRepository = new DriverRepository();
                        DriverDTO driver = driverRepository.GetDriverByID(driverid);
                        taxiRequestDTO.Driver = driver;

                        int vehicleId = Convert.ToInt32(reader["vehicleid"]);
                        VehicleRepository vehicleRepository = new VehicleRepository();
                        VehicleDTO vehicle = vehicleRepository.GetVehicleByID(vehicleId);
                        taxiRequestDTO.Vehicle = vehicle;

                        taxiRequestDTOs.Add(taxiRequestDTO);
                    }
                }
            }
            return taxiRequestDTOs;
        }

        

        private List<CargoRequestDTO> GetCargoRequests()
        {
            List<CargoRequestDTO> cargoRequestDTOs = new List<CargoRequestDTO>();

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.transport;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CargoRequestDTO cargoRequestDTO = new CargoRequestDTO();

                        cargoRequestDTO.Id = Convert.ToInt32(reader["transportid"]);
                        cargoRequestDTO.TransportDateTime = (DateTime)reader["transportdatetime"];
                        cargoRequestDTO.TransportType = (TransportType)Convert.ToInt32(reader["transporttype"]);
                        cargoRequestDTO.TransportStatus = (TransportStatus)Convert.ToInt32(reader["transportstatus"]);
                        cargoRequestDTO.TransportWeight = Convert.ToInt32(reader["passengercount"]);

                        int pickupAddressID = Convert.ToInt32(reader["pickupaddressid"]);
                        AddressRepository addressRepository = new AddressRepository();
                        AddressDTO pickupAddress = addressRepository.GetAddressByID(pickupAddressID);
                        cargoRequestDTO.PickupAddress = pickupAddress;

                        int destinationAddressID = Convert.ToInt32(reader["destinationaddressid"]);
                        AddressDTO destinationAddress = addressRepository.GetAddressByID(destinationAddressID);
                        cargoRequestDTO.PickupAddress = pickupAddress;

                        int driverid = Convert.ToInt32(reader["driverid"]);
                        DriverRepository driverRepository = new DriverRepository();
                        DriverDTO driver = driverRepository.GetDriverByID(driverid);
                        cargoRequestDTO.Driver = driver;

                        int vehicleId = Convert.ToInt32(reader["vehicleid"]);
                        VehicleRepository vehicleRepository = new VehicleRepository();
                        VehicleDTO vehicle = vehicleRepository.GetVehicleByID(vehicleId);
                        cargoRequestDTO.Vehicle = vehicle;

                        cargoRequestDTOs.Add(cargoRequestDTO);
                    }
                }
            }
            return cargoRequestDTOs;
        }

        //ToDo: DRY voor het ophalen van transports.

        public void AddTaxiTransport(TaxiRequestDTO taxiRequestDTO, int pickupAddressId, int destinationAddressId)
        {
            string query = "INSERT INTO transport (transportType, pickupAddressId, destinationAddressId, transportDateTime, passengerCount) VALUES (@transportType, @pickupAddressid, @destinationAddressid, @DateTime, @passengerCount)";
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                AddTransport(taxiRequestDTO, pickupAddressId, destinationAddressId, query);
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
                AddTransport(cargoRequestDTO, pickupAddressId, destinationAddressId, query);
                cmd.Parameters.AddWithValue("@transportWeight", cargoRequestDTO.TransportWeight);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        
        private void AddTransport(TransportDTO transportDTO, int pickupAddressId, int destinationAddressId, string query)
        {
            sqlConnection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@transportType", transportDTO.TransportType.ToString());
                cmd.Parameters.AddWithValue("@pickupAddressId", pickupAddressId);
                cmd.Parameters.AddWithValue("@destinationAddressId", destinationAddressId);
                cmd.Parameters.AddWithValue("@DateTime", transportDTO.TransportDateTime);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}