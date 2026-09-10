using ConsoleApp1;
using ConsoleApp1.HR;


public class Program
{
    static void Main()
    { 
    List<Employee> employees = new List<Employee>();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("***********************************");
    Console.WriteLine("* Jawad's Pie Shop Employee App *");
    Console.WriteLine("***********************************");
    Console.ForegroundColor = ConsoleColor.White;

    string userSelection;
    Console.ForegroundColor = ConsoleColor.Blue;
    //TODO Check if file with employees exsist
    Utilities.CheckEmployeeExsistInFile();
    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Loaded {employees.Count} employee(S)\n\n");
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("********************");
        Console.WriteLine("* Select an action *");
        Console.WriteLine("********************");

        Console.WriteLine("1: Register Employee");
        Console.WriteLine("2: View All Empoyees");
        Console.WriteLine("3: Save data to FILE");
        Console.WriteLine("4: Load data from FILE");
        Console.WriteLine("5: Find specific employee");
        Console.WriteLine("9: Quit application");

        Console.WriteLine("Your selection: ");
        userSelection = Console.ReadLine();

        switch (userSelection)
        {
            case "1": 
                Utilities.RegisterEmployee(employees);
            break;

            case "2": 
                Utilities.ViewAllEmployee(employees);
            break;
            case "3": 
                Utilities.SaveEmployeeToFile(employees);
            break;
            case "4": 
                Utilities.LoadEmployeeToFile(employees);
            break;
            case "5": 
                Utilities.FindEmployeeById(employees);
            break;
            case "9": break;
            default: System.Console.WriteLine("Invalid selection. Please try again."); 
            break;
        }

    } while (userSelection != "9");

    Console.WriteLine("Thanks For using the application");
    }  

}

