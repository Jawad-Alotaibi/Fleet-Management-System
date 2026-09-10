using System;

namespace ConsoleApp1.HR;

public class Manager : Employee
{

    public Manager(string fName, string lName, string email, double? hourlyRate) : base(fName, lName, email, hourlyRate)
    {
        
    }

    public void AttendenceManagementMettings()
    {
        NumberOfHoursWorked += 10;
        Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email!");
    }
    public override void GiveBonus()
    {
        Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 400!");
    }
}
