using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class TransportCompany
    {
        private List<Vehicle> _vehicles = new();
        private string _name;

        public IReadOnlyList<Vehicle> Vehicles { get { return _vehicles; } }
        public string Name { get { return _name; } }

        public TransportCompany(string name)
        {
            _name = name;
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<VehicleDTO> data = vehicleRepository.GetVehicles();

            foreach (VehicleDTO vehicleDTO in data)
            {
                Vehicle vehicle = new Vehicle(
                    vehicleDTO.VehicleBrandModel,
                    (Core.Domain.VehicleType)vehicleDTO.VehicleType,
                    vehicleDTO.LicencePlate,
                    vehicleDTO.MaxLoad,
                    vehicleDTO.MaxPersons);
                _vehicles.Add(vehicle);
            }
        }

    }
}
