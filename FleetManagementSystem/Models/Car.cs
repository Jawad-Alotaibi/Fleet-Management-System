namespace FleetManagementSystem.Models;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string reg, string man, int year, int doors)
        : base(reg, man, year)
    {
        NumberOfDoors = doors;
    }

    // Task 4.1 – Override Start method for Car
    public override void Start()
    {    
      Console.WriteLine("Car engine is starting smoothly...");
    }



    // Task 5.2 – Override DisplayInfo in Car
      public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number Of doors: {NumberOfDoors}");
    }

}
