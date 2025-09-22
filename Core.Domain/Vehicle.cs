
namespace Core.Domain;

public class Vehicle
{
    private VehicleType _vehicleType;

    public VehicleType Type { get { return _vehicleType; } }

    public Vehicle(VehicleType vehicleType)
    {
        _vehicleType = vehicleType;
    }


}
