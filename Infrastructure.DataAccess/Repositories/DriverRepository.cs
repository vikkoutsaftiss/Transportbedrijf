using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories
{
    public class DriverRepository
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=100.77.225.128;Database=TransporTDB;UserId=Vik;Password=H1209mysql!;");

        public List<DriverDTO> GetDrivers()
        {
            List<DriverDTO> drivers = new List<DriverDTO>();

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.driver;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DriverDTO driver = new DriverDTO();

                        driver.id = Convert.ToInt32(reader["driverid"]);
                        driver.name = reader["drivername"].ToString();
                        drivers.Add(driver);
                    }
                }
            }
            sqlConnection.Close();
            return drivers;
        }

        public DriverDTO GetDriverByID(int driverid)
        {
            DriverDTO driver = new DriverDTO();
            int id = driverid;

            sqlConnection.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM TransporTDB.driver;", sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (id == Convert.ToInt32(reader["driverid"]))
                        {
                            driver.id = Convert.ToInt32(reader["driverid"]);
                            driver.name = reader["drivername"].ToString();
                        }
                    }
                }
                sqlConnection.Close();
                return driver;
            }
        }


    }
}

