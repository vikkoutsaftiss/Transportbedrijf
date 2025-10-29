using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class TruckDTO : VehicleDTO
    {
        public int MaxLoad { get; set; }
    }
}
