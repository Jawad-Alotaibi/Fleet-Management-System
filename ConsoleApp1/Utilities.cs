using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using ConsoleApp1.HR;

namespace ConsoleApp1
{
    public static class Utilities
    {
        private static string directory = "/Users/jawad/Documents/Expermints/C#/ConsoleApp1/employees";

        private static string fileName = "employers.txt";
        // private static string path = Path.Combine(directory, fileName);


        public static void CheckEmployeeExsistInFile()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string path = Path.Combine(directory, fileName);
            bool existingFileFound = File.Exists(path);

            if (existingFileFound)
            {
                Console.WriteLine("An Existing file with employee data is found.");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"Directory {directory} is ready for saving files.");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        public static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("\nCreating an Employee");

            Console.WriteLine("What type of employee do you wanna register?");
            Console.WriteLine("1. Employee\n2. Manager\n3. Store Manager\n4. Researcher\n5. Junior researcher");
            Console.WriteLine("Enter your selection: ");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.WriteLine("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the hourly rate: ");
            double rate = double.Parse(Console.ReadLine());

            Employee employee = null;

            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, rate);
                    break;
                case "5":
                    employee = new JuniorResearcher(firstName, lastName, email, rate);
                    break;

            }

            employees.Add(employee);
            Console.WriteLine("Employee created!\n\n");
        }

        public static void ViewAllEmployee(List<Employee> employees)
        {
            // if (employees is null)
            // {
            //     Console.WriteLine("List is empty");
            //     return;
            // }
            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }
        }

        private static string GetEmployeeType(Employee e)
        {
            if (e is Manager)
                return "2";

            else if (e is StoreManager)
                return "3";
            else if (e is JuniorResearcher)
                return "5";

            else if (e is Researcher)
                return "4";

            else if (e is Employee)
                return "1";

            return "0";
        }
        public static void SaveEmployeeToFile(List<Employee> employees)
        {
            string path = Path.Combine(directory, fileName);
            StringBuilder sb = new StringBuilder();


            foreach (var employee in employees)
            {
                string type = GetEmployeeType(employee);
                sb.Append($"firstName: {employee.FirstName};");
                sb.Append($"lastName: {employee.LastName};");
                sb.Append($"email: {employee.Email};");
                sb.Append($"hourlyRate: {employee.HourlyRate};");
                sb.Append($"type: {type};");
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved employees successfully");
            Console.ResetColor();
        }

        public static void LoadEmployeeToFile(List<Employee> employees)
        {
            string path = Path.Combine(directory, fileName);

            try
            {
                if (File.Exists(path))
            {
                employees.Clear(); //remove all the elements from the memory
            }
            string[] employeesAsString = File.ReadAllLines(path);

            //now read the file
            for (int i = 0; i < employeesAsString.Length; i++)
            {
                string[] employeeSplits = employeesAsString[i].Split(";");
                string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(':') + 1).Trim();
                string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(':') + 1).Trim();
                string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(':') + 1).Trim();
                double rate = double.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(':') + 1).Trim());
                string employeeType = employeeSplits[4].Substring(employeeSplits[4].IndexOf(':') + 1).Trim();

                Employee employee = null;
                switch (employeeType)
                {
                    case "1":
                        employee = new Employee(firstName, lastName, email, rate);
                        break;
                    case "2":
                        employee = new Manager(firstName, lastName, email, rate);
                        break;
                    case "3":
                        employee = new StoreManager(firstName, lastName, email, rate);
                        break;
                    case "4":
                        employee = new Researcher(firstName, lastName, email, rate);
                        break;
                    case "5":
                        employee = new JuniorResearcher(firstName, lastName, email, rate);
                        break;
                }

                if (employee is not null)
                {
                    employees.Add(employee);
                }
            }    
            } catch (FileNotFoundException f)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The File couldn't be found!");
                Console.WriteLine(f.Message);
                Console.WriteLine(f.StackTrace);
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Loaded {employees.Count} employees!\n\n");
            Console.ResetColor();
        }

        public static void FindEmployeeById(List<Employee> employees)
        {
            Console.WriteLine("Enter Employee ID you want to visualize: ");
            try
            {
                int employeeId = int.Parse(Console.ReadLine());
                Employee selectedEmployee = employees[employeeId];
                selectedEmployee.DisplayEmployeeDetails();
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{e.Message}\n\n");
                Console.WriteLine($"{e.StackTrace}\n\n");
                Console.ResetColor();
            }
            
        }

    }
}
