using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class TaxiRequestDTO : TransportDTO
    {
        public int PassengerCount { get; set; }
    }
}
