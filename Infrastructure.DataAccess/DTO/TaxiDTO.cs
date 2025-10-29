using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class TaxiDTO : VehicleDTO
    {
        public int MaxPersons { get; set; }
        
    }
}
