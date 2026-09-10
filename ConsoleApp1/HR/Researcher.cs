using System;

namespace ConsoleApp1.HR;

public class Researcher : Employee
{   
     private int numberOfPieTastesInvented = 0;

    public int NumberOfPieTastesInvented
    {
        get => numberOfPieTastesInvented;
        set => numberOfPieTastesInvented = value;
    }

    public Researcher(string fName, string lName, string email, double? hourlyRate) : base(fName, lName, email, hourlyRate)
    {
    }

    public void ResearchNewPieTastes(int researchHours)
    {
        NumberOfHoursWorked += researchHours;

        if(new Random().Next(100) > 50)
        {
            NumberOfPieTastesInvented++;
            Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste! total number of pies invented: {numberOfPieTastesInvented}");
        } 
        else
        {
            Console.WriteLine($"Researcher {FirstName} {LastName} is working still  on a new pie taste!");
        }
    }
}
