using TransporT.Shared.Enums;

namespace Infrastructure.DataAccess.DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; } 
        public string VehicleBrandModel { get; set; }
        public  VehicleType VehicleType { get; set; } // Object VehicleType VehicleType aangepast naar int VehicleType. Cycle detected. Ik heb een referentie gelegd tussen Core.Domain <--> Infrastructure.DataAccess. Vragen hoe dit op te lossen is, ik heb denk ik namelijk het object VehicleType nodig.
        public string LicencePlate {  get; set; }
        public int TotalDriven {  get; set; }
              
    }
}
