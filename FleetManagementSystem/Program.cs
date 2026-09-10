using FleetManagementSystem.Models;
using FleetManagementSystem.Interfaces;

Console.WriteLine("Fleet Management System");
Console.WriteLine();

// Inheritance-based polymorphism
List<Vehicle> fleet = new List<Vehicle>
{
    new Car("CAR123", "Toyota", 2022, 4),
    new Truck("TRK789", "Volvo", 2020, 18.5)
};

foreach (var vehicle in fleet)
{
    vehicle.Start();
    vehicle.DisplayInfo();
    Console.WriteLine();
}

// Task 8.3 – Demonstrate interface-based polymorphism
Console.WriteLine("Maintenance Operations:");
Console.WriteLine();


List<IMaintainable> maintainableItems = new List<IMaintainable>
{
    new Car("CAR555", "Honda", 2021, 4),
    new Truck("TRK222", "MAN", 2019, 20),
    new OfficeAsset("Main Office Generator")
};

foreach(var item in maintainableItems)
{
  item.PerformMaintenance();
}



