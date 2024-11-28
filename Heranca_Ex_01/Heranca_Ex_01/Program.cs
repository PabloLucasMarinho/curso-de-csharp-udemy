using System.Globalization;
using Heranca_Ex_01.Entities;

Console.Write("Enter number of employees: ");
int quantity = int.Parse(Console.ReadLine());
List<Employee> employees = [];

for (int i = 0; i < quantity; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Employee #{i + 1} data:");
    Console.Write("Outsourced (y/n)? ");
    char response = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: $");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Employee employee;

    if (response == 'y')
    { 
        Console.Write("Additional charge: $");
        double additionalCharge = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

        employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
    }else
    {
        employee = new(name, hours, valuePerHour);
    }
    
    employees.Add(employee);
}
Console.WriteLine("");
Console.WriteLine("PAYMENTS:");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}