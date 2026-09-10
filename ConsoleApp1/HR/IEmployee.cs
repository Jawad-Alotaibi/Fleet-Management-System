using System;

namespace ConsoleApp1.HR;

public interface IEmployee
{
    double ReceiveWage();
    void GiveBonus();
    void PerformWork();
    void StopWorking();
    void DisplayEmployeeDetails();
    void GiveCompliment();
}
