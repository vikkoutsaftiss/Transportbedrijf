using Core.Domain;

namespace Infrastructure.DataAccess.DTO
{
    public class VehicleDTO
    {
        public string VehicleBrandModel { get; set; }
        public VehicleType VehicleType { get; set; } //Cycle detected. Ik heb een referentie gelegd tussen Core.Domain <--> Infrastructure.DataAccess. Vragen hoe dit op te lossen is, ik heb denk ik namelijk het object VehicleType nodig.
        public string LicencePlate {  get; set; }
        public int TotalDriven {  get; set; }
        public int? MaxLoad {  get; set; }
        public int? MaxPersons { get; set; }

        public List<VehicleDTO> GetVehicles()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>();
            {
                new VehicleDTO()
                {
                    VehicleBrandModel = "Volvo XC90",
                    VehicleType = VehicleType.Taxi,
                    LicencePlate = "DTO-12-D",
                    TotalDriven = 0,
                    MaxLoad = null,
                    MaxPersons = 4
                };
                new VehicleDTO()
                {
                    VehicleBrandModel = "DAF F80",
                    VehicleType = VehicleType.Truck,
                    LicencePlate = "DTO-12-F",
                    TotalDriven = 0,
                    MaxLoad = 3000,
                    MaxPersons = null
                };
            };
            return vehicles;
        }       
      
    }
}
