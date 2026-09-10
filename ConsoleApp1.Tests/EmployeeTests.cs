using ConsoleApp1.HR;

namespace ConsoleApp1.Tests;

public class EmployeeTests
{
    [Fact] //attribute
    public void PerformWork_Adds_NumberOfHours()
    {
        //Arrange
        Employee employee = new Employee("Jawad", "Alotaibi", "j.alotaibi@gama-ksa@gmail.com", 23);
        int numberOfHoursWorked = 3;
        //Act
        employee.PerformWork(numberOfHoursWorked);
        //Assert
        Assert.Equal(3, employee.NumberOfHoursWorked);
    }

    [Fact]
    public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
    {
        //Arrange
        Employee employee = new Employee("d7mi", "Alotaibi", "d.alotaibi@gama-ksa@gmail.com", 34);
        
        //Act
        employee.PerformWork();
        //Assert
        Assert.Equal(1, employee.NumberOfHoursWorked);
    }
}
