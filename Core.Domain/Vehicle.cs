
namespace Core.Domain;

public class Vehicle
{
    private string _vehicleBrandModel;
    private VehicleType _vehicleType;
    private string _licencePlate;
    private int _totalDriven;

    public string VehicleBrandModel { get { return _vehicleBrandModel; } }
    public VehicleType Type { get { return _vehicleType; } }
    public string LicencePlate { get { return _licencePlate; } }
    public int TotalDriven {  get { return _totalDriven; } }


    public Vehicle(string vehicleBrandModel, VehicleType vehicleType, string licencePlate)
    {
        _vehicleBrandModel = vehicleBrandModel;
        _vehicleType = vehicleType;
        _licencePlate = licencePlate;
        
    }

    //ToDo: TotalDriven bouwen. Waarschijnlijk een helper voor aanmaken!


}
