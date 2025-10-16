using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Models.Transport
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
                Vehicle vehicle;

                if (vehicleDTO is TruckDTO truckDTO)
                {
                    vehicle = new Truck(
                        truckDTO.VehicleBrandModel,
                        (VehicleType)truckDTO.VehicleType,
                        truckDTO.LicencePlate,
                        truckDTO.MaxLoad);
                }
                else if (vehicleDTO is TaxiDTO taxiDTO)
                {
                    vehicle = new Taxi(
                        taxiDTO.VehicleBrandModel,
                        (VehicleType)taxiDTO.VehicleType,
                        taxiDTO.LicencePlate,
                        taxiDTO.MaxPersons);
                }
                else
                {
                    vehicle = new Vehicle(
                        vehicleDTO.VehicleBrandModel,
                        (VehicleType)vehicleDTO.VehicleType,
                        vehicleDTO.LicencePlate);
                }

                _vehicles.Add(vehicle);
            }
        }

    }
}
