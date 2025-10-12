using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Taxi : Vehicle
    {
        private int _maxPersons;

        public int MaxPersons { get { return _maxPersons; } }


        public Taxi(string vehicleBrandModel, VehicleType vehicleType, string licencePlate, int maxPersons) 
            : base(vehicleBrandModel, vehicleType, licencePlate)
        {
            _maxPersons = maxPersons;
        }
    }
}
