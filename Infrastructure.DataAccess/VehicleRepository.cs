using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class VehicleRepository
    {
        public List<VehicleDTO> GetVehicles()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>()
            {
                new VehicleDTO()
                {
                    VehicleBrandModel = "Volvo XC90",
                    VehicleType = 1,
                    LicencePlate = "DTO-12-D",
                    TotalDriven = 0,
                    MaxLoad = null,
                    MaxPersons = 4
                },
                new VehicleDTO()
                {
                    VehicleBrandModel = "DAF F80",
                    VehicleType = 0,
                    LicencePlate = "DTO-12-F",
                    TotalDriven = 0,
                    MaxLoad = 3000,
                    MaxPersons = null
                }
            };
            return vehicles;
        }
    }
}
