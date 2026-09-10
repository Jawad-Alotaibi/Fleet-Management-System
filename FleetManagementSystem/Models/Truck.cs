namespace FleetManagementSystem.Models;

public class Truck : Vehicle
{
    public double LoadCapacity { get; set; }

    public Truck(string reg, string man, int year, double capacity)
        : base(reg, man, year)
    {
        LoadCapacity = capacity;
    }

    // Task 4.2 – Override Start method for Truck
    public override void Start()
    {
        Console.WriteLine("Truck is performing safety checks and starting loudly...");
    }
   

    // Task 5.3 – Override DisplayInfo in Truck
   public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Load Capacity: {LoadCapacity}");
    }

    // Task 8.1 – Override PerformMaintenance in Truck
    public override void PerformMaintenance()
  {
    Console.WriteLine($"Inspecting heavy-duty components of truck {RegistrationNumber}");
  }
}
