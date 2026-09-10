using System;

namespace ConsoleApp1.HR;

//value type
public struct WorkTask
{
    public string descrption;
    public int hours;

    public void PerformWork()
    {
        Console.WriteLine($"Task {descrption} of {hours} hour(s) has been performed.");
    }
}
