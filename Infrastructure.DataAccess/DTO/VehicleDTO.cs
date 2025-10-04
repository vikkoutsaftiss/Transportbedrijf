namespace Infrastructure.DataAccess.DTO
{
    public class VehicleDTO
    {
        public string VehicleBrandModel { get; set; }
        public int VehicleType { get; set; } // Object VehicleType VehicleType aangepast naar string VehicleType. Cycle detected. Ik heb een referentie gelegd tussen Core.Domain <--> Infrastructure.DataAccess. Vragen hoe dit op te lossen is, ik heb denk ik namelijk het object VehicleType nodig.
        public string LicencePlate {  get; set; }
        public int TotalDriven {  get; set; }
        public int? MaxLoad {  get; set; }
        public int? MaxPersons { get; set; }

        
      
    }
}
