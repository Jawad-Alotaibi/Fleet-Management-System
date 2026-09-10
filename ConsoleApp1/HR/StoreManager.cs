using System;

namespace ConsoleApp1.HR;

public class StoreManager : Employee
{
    public StoreManager()
    {
    }

    public StoreManager(string fName, string lName, string email, double? hourlyRate) 
    : base(fName, lName, email, hourlyRate)
    {
        
    }
}
