using System;
using Newtonsoft.Json;

namespace ConsoleApp1.HR;


public class Employee : IEmployee
{
    //Fields is class-level variable to store data belong to the object
    //auto-proprties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public readonly string Department;
    private Address address;
    public double? hourlyRate;
    public double? HourlyRate
    {
        get => hourlyRate;
        set
        {
            if (value == null)
            {
                hourlyRate = 10;
            }
            else if (value < 0)
            {
                Console.WriteLine("Hourly rate cannot be negative. setting to 0");
            }
            else
            {
                hourlyRate = value;
            }
        }
    }
    private int numberOfHoursWorked;
    public double wage { get; private set; }
    public static double taxRate = 0.15;
    const int minimalHoursWorkedUnit = 1; // this value cannot be changed during the lifetime of the app

    public int NumberOfHoursWorked
    {
        get { return numberOfHoursWorked; }
        protected set { numberOfHoursWorked = value; }
    }

    public Address Address { get => address; set => address = value; }

    //Methods are used to Perform actions for example change the state of the object 
    public Employee(string fName, string lName, string email,
    double? hourlyRate) // Constructor -> it's a method automaticaly called when create the object and set intial values to the object 
    {
        FirstName = fName;
        LastName = lName;
        this.Email = email;
        this.HourlyRate = hourlyRate;
    }

    public Employee(string firstName, string lastName, string email,
    double? hourlyRate, string street, string houseNumber, string zipCode, string city) // Constructor -> it's a method automaticaly called when create the object and set intial values to the object 
    {
        FirstName = firstName;
        LastName = lastName;
        this.Email = email;
        this.HourlyRate = hourlyRate;
        Address = new Address(street, houseNumber, zipCode, city);
    }


    public Employee(string fName, string lName, string email,
    double? rate, string department) // Constructor -> it's a method automaticaly called when create the object and set intial values to the object 
    {
        FirstName = fName;
        LastName = lName;
        this.Email = email;
        this.HourlyRate = rate;
        Department = department;
    }

    public Employee(string fName, string last)
    : this(fName, last, "jawad@gama-ksa.com", 20) // Constructor chaining-> it's a method automaticaly called when create the object and set intial values to the object 
    {}

    public Employee()
    {

    }
    public void PerformWork(int numberOfHours)
    {
        NumberOfHoursWorked += numberOfHours;
        Console.WriteLine($"{FirstName} {LastName} has worked for {NumberOfHoursWorked} hour(s).");
    }

    public void ChangeDepartment(string newDepartment)
    {
        // Department = newDepartment;
    }
    //Overload
    public void PerformWork()
    {
        PerformWork(minimalHoursWorkedUnit);
    }


    public double ReceiveWage(bool resetHours = true)
    {
        double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;

        double taxAmount = wageBeforeTax * taxRate;
        wage = wageBeforeTax - taxAmount;
        Console.WriteLine($"{FirstName} {LastName} has received a wage of {wage} for {NumberOfHoursWorked} hour(s).");

        if (resetHours)
        {
            NumberOfHoursWorked = 0;
        }


        return wage;
    }

    public void DisplayEmployeeDetails()
    {

        Console.WriteLine("\nFirstName: " + FirstName +
        "\nLast Name: " + LastName +
        "\nEmail: " + Email +
        "\nHourly Rate: " + HourlyRate +
        "\nHours Worked: " + NumberOfHoursWorked +
        "\nTax Rate: " + taxRate +
        "\nDepartment: " + Department);
    }
    public static void DisplayTaxtRate()
    {
        Console.WriteLine($"The current tax rate is: {taxRate}");
    }
    public string ConvertToJson()
    {
        string json = JsonConvert.SerializeObject(this);
        return json;
    }

    public virtual void GiveBonus()
    {
        Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
    }

    public double ReceiveWage() // need to be exact match with the signiture in the interface in my class i have optional parameter reset hours
    {
        return ReceiveWage(resetHours: true);
    }

    public void StopWorking()
    {
        NumberOfHoursWorked = 0;
        Console.WriteLine($"{FirstName} {LastName} stopped working and hours were reset.");
    }

    public void GiveCompliment()
    {
        Console.WriteLine($"You've done a great job, {FirstName}");
    }
}

