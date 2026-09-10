using System;

namespace ConsoleApp1.HR;

public class Developer : Employee
{
    private string currentProject;

    public string CurrentProject
    {
        get => currentProject;
        set => currentProject = value;
    }

    public Developer(string fName, string lName, string email, double? hourlyRate) : base(fName, lName, email, hourlyRate)
    {
    }
}
