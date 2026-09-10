using System;

namespace ConsoleApp1.HR;

public class JuniorResearcher : Researcher
{

    public JuniorResearcher(string fName, string lName, string email, double? hourlyRate) 
    : base(fName, lName, email, hourlyRate)
    {
    }

    public override void GiveBonus()
    {
        Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 150!");
    }
}
