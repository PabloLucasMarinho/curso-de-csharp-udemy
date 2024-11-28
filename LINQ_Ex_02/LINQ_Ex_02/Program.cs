using LINQ_Ex_02.Entities;
using System.Globalization;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\in.txt";

List<Employee> employees = [];

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
        employees.Add(new(name, email, salary));
    }
}

Console.Write("Enter salary: $");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Email of people whose salary is more than ${value.ToString("F2", CultureInfo.InvariantCulture)}:");
var emails = employees.Where(e => e.Salary > value).OrderBy(e => e.Email).Select(e => e.Email);
foreach (string email in emails)
{
    Console.WriteLine(email);
}

var salarySum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
Console.Write($"Sum of salary of people whose name starts with 'M': ${salarySum.ToString("F2", CultureInfo.InvariantCulture)}");