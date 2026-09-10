using FleetManagementSystem.Interfaces;

namespace FleetManagementSystem.Models;

// Task 7.1 – Implement IMaintainable in Vehicle
//All derived classes automatically become maintainable.
public class Vehicle : IMaintainable
{
    public string RegistrationNumber { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }

    public Vehicle(string registrationNumber, string manufacturer, int year)
    {
        RegistrationNumber = registrationNumber;
        Manufacturer = manufacturer;
        Year = year;
    }

  public virtual void PerformMaintenance()
  {
    Console.WriteLine($"Performing general maintenance for {RegistrationNumber}");
  }
    // Task 3.1 – Mark Start method as virtual
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }

    // Task 5.1 – Mark DisplayInfo method as virtual
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Reg: {RegistrationNumber}, Manufacturer: {Manufacturer}, Year: {Year}");
    }

    // Task 7.2 – Add PerformMaintenance method

}
