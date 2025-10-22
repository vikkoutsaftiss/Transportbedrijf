using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporT.Shared.Enums;

namespace Core.Domain.Models.Vehicles
{
    public class Truck : Vehicle
    {
        private int _maxLoad;
        public int MaxLoad { get { return _maxLoad; } }
        
        
        public Truck(string vehicleBrandModel, VehicleType vehicleType, string licencePlate, int maxLoad)
            : base(vehicleBrandModel, vehicleType, licencePlate)
        {
            _maxLoad = maxLoad;
        }
        
    }
}
