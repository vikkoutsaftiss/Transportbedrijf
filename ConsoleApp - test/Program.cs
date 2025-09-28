// See https://aka.ms/new-console-template for more information
using Core.Domain;
using System.Reflection.Metadata.Ecma335;

Driver driver1 = new Driver("Henk");
Vehicle vehicle1 = new Vehicle("Tesla Model X", VehicleType.Taxi, "GBR-10-S", null, 4);

Driver driver2 = new Driver("Johan");
Vehicle vehicle2 = new Vehicle("Scania S770", VehicleType.Truck, "HLP-12-F", 4000, null);

Transport transport1 = new Transport(
    "De Streep 6, Diessen", 
    "Lariksplaats 89, Tilburg", 
    DateTime.Now, 
    vehicle1, 
    driver1,
    TransportType.Passenger,
    null, 
    3);

Transport transport2 = new Transport(
    "Lalala 1, Zaandam",
    "Blablabla 2, Maastricht",
    DateTime.Now,
    vehicle2,
    driver2,
    TransportType.Cargo,
    null,
    3000);

bool result1 = transport1.TryStart(transport1);
bool result2 = transport2.TryStart(transport2);

Console.WriteLine($"Transport van {transport1.PickUpAddress} naar {transport1.DestinationAddress} met {transport1.Driver.Name} in een {transport1.Vehicle.VehicleBrandModel} ({transport1.Vehicle.LicencePlate}) op {transport1.DateTime}. Type: {transport1.TransportType}");
Console.WriteLine($"Details: {(transport1.TransportWeight.HasValue ? $"Gewicht: {transport1.TransportWeight} kg" : $"Aantal personen: {transport1.PassengerCount}")}");
Console.WriteLine();
Console.WriteLine($"Transport van {transport2.PickUpAddress} naar {transport2.DestinationAddress} met {transport2.Driver.Name} in een {transport2.Vehicle.VehicleBrandModel} ({transport2.Vehicle.LicencePlate}) op {transport2.DateTime}. Type: {transport2.TransportType}");
Console.WriteLine($"Details: {(transport2.TransportWeight.HasValue ? $"Gewicht: {transport2.TransportWeight} kg" : $"Aantal personen: {transport2.PassengerCount}")}");
Console.WriteLine();

if (result1 == false)
{
    Console.WriteLine($"De rit van {transport1.PickUpAddress} naar {transport1.DestinationAddress} mag niet gestart worden. Controlleer de gegevens");    
}
if (result2 == false)
{
    Console.WriteLine($"De rit van {transport2.PickUpAddress} naar {transport2.DestinationAddress} mag niet gestart worden. Controlleer de gegevens");
}
if (result1 == true)
{
    Console.WriteLine($"De rit van {transport1.PickUpAddress} naar {transport1.DestinationAddress} mag gestart worden.");
}
if (result2 == true)
{
    Console.WriteLine($"De rit van {transport2.PickUpAddress} naar {transport2.DestinationAddress} mag gestart worden.");
}

Console.ReadKey();