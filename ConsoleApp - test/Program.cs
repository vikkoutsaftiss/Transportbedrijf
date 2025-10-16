// See https://aka.ms/new-console-template for more information
using Core.Domain.Models.Employees;
using Core.Domain.Models.Transport;
using Core.Domain.Models.Vehicles;
using Infrastructure.DataAccess;
using System.Reflection.Metadata.Ecma335;

TransportCompany transportCompany = new TransportCompany("TransporT");


Driver driver1 = new Driver("Henk");

Driver driver2 = new Driver("Johan");

//TransportRequest transport1 = new TransportRequest(
//    "De Streep 6, Diessen",
//    "Lariksplaats 89, Tilburg",
//    DateTime.Now,
//    transportCompany.Vehicles.First(v => v.VehicleType == VehicleType.Taxi),
//    driver1,
//    TransportType.Passenger,
//    null,
//    3);

//TransportRequest transport2 = new TransportRequest(
//    "Lalala 1, Zaandam",
//    "Blablabla 2, Maastricht",
//    DateTime.Now,
//    transportCompany.Vehicles.First(v => v.VehicleType == VehicleType.Truck),
//    driver2,
//    TransportType.Cargo,
//    null,
//    3000);

//bool result1 = transport1.TryStart();
//bool result2 = transport2.TryStart();

//Console.WriteLine($"Transport van {transport1.PickUpAddress} naar {transport1.DestinationAddress} met {transport1.Driver.Name} in een {transport1.Vehicle.VehicleBrandModel} ({transport1.Vehicle.LicencePlate}) op {transport1.DateTime}. Type: {transport1.TransportType}");
//Console.WriteLine($"Details: {(transport1.TransportWeight.HasValue ? $"Gewicht: {transport1.TransportWeight} kg" : $"Aantal personen: {transport1.PassengerCount}")}");
//Console.WriteLine();
//Console.WriteLine($"Transport van {transport2.PickUpAddress} naar {transport2.DestinationAddress} met {transport2.Driver.Name} in een {transport2.Vehicle.VehicleBrandModel} ({transport2.Vehicle.LicencePlate}) op {transport2.DateTime}. Type: {transport2.TransportType}");
//Console.WriteLine($"Details: {(transport2.TransportWeight.HasValue ? $"Gewicht: {transport2.TransportWeight} kg" : $"Aantal personen: {transport2.PassengerCount}")}");
//Console.WriteLine();

foreach (Vehicle vehicle in transportCompany.Vehicles)
{
    Console.WriteLine($"Merk en model: {vehicle.VehicleBrandModel}, type: {vehicle.VehicleType}");
}

//if (result1 == false)
//{
//    Console.WriteLine($"De rit van {transport1.PickUpAddress} naar {transport1.DestinationAddress} mag niet gestart worden. Controlleer de gegevens");
//}
//if (result2 == false)
//{
//    Console.WriteLine($"De rit van {transport2.PickUpAddress} naar {transport2.DestinationAddress} mag niet gestart worden. Controlleer de gegevens");
//}
//if (result1 == true)
//{
//    Console.WriteLine($"De rit van {transport1.PickUpAddress} naar {transport1.DestinationAddress} mag gestart worden.");
//}
//if (result2 == true)
//{
//    Console.WriteLine($"De rit van {transport2.PickUpAddress} naar {transport2.DestinationAddress} mag gestart worden.");
//}

Console.ReadKey();