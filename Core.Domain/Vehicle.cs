
namespace Core.Domain;

public class Vehicle
{
    private int _Id;
    private string _vehicleBrandModel;
    private VehicleType _vehicleType;
    private string _licencePlate;
    private int _totalDriven;

    public int Id { get { return _Id; } }
    public string VehicleBrandModel { get { return _vehicleBrandModel; } }
    public VehicleType VehicleType { get { return _vehicleType; } }
    public string LicencePlate { get { return _licencePlate; } }
    public int TotalDriven {  get { return _totalDriven; } }


    public Vehicle(string vehicleBrandModel, VehicleType vehicleType, string licencePlate)//, int? maxLoad = null, int? maxPersons = null)
    {
        _vehicleBrandModel = vehicleBrandModel;
        _vehicleType = vehicleType;
        _licencePlate = licencePlate;
        _totalDriven = 0;

        //if (maxLoad.HasValue)
        //{
        //    _maxLoad = maxLoad;
        //}
        //else if (maxPersons.HasValue)
        //{
        //    _maxPersons = maxPersons;
        //}
        
    }

    //ToDo: TotalDriven bouwen. Waarschijnlijk een helper voor aanmaken!


}
