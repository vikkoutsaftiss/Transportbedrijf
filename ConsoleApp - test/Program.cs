// See https://aka.ms/new-console-template for more information
using Core.Domain;

Driver driver1 = new Driver("Henk");
Vehicle vehicle1 = new Vehicle("Tesla Model X", VehicleType.Taxi, "GBR-10-S");

Driver driver2 = new Driver("Johan");
Vehicle vehicle2 = new Vehicle("Scania S770", VehicleType.Truck, "HLP-12-F");

Transport transport1 = new Transport(
    "De Streep 6, Diessen", 
    "Lariksplaats 89, Tilburg", 
    DateTime.Now, 
    vehicle1, 
    driver1, 
    null, 
    3);

Transport transport2 = new Transport(
    "Lalala 1, Zaandam",
    "Blablabla 2, Maastricht",
    DateTime.Now,
    vehicle2,
    driver2,
    3000,
    null);

Console.WriteLine($"Transport van {transport1.PickUpAddress} naar {transport1.DestinationAddress} met {transport1.Driver.Name} in een {transport1.Vehicle.VehicleBrandModel} ({transport1.Vehicle.LicencePlate}) op {transport1.DateTime}. Type: {transport1.TransportType}");
Console.WriteLine($"Details: {(transport1.TransportWeight.HasValue ? $"Gewicht: {transport1.TransportWeight} kg" : $"Aantal personen: {transport1.PassengerCount}")}");
Console.WriteLine();
Console.WriteLine($"Transport van {transport2.PickUpAddress} naar {transport2.DestinationAddress} met {transport2.Driver.Name} in een {transport2.Vehicle.VehicleBrandModel} ({transport2.Vehicle.LicencePlate}) op {transport2.DateTime}. Type: {transport2.TransportType}");
Console.WriteLine($"Details: {(transport2.TransportWeight.HasValue ? $"Gewicht: {transport2.TransportWeight} kg" : $"Aantal personen: {transport2.PassengerCount}")}");

Console.ReadKey();