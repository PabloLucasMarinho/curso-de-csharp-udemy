using System.Globalization;
using Abstratos_Ex_2.Entities;

Console.Write("Enter the number of tax payers: ");
int quantity = int.Parse(Console.ReadLine());
List<TaxPayer> taxPayers = [];

for (int i = 1;  i <= quantity; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char response = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: $");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (response == 'i')
    {
        Console.Write("Health expenditures: $");
        double healthExpends = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

        taxPayers.Add(new Individual(name, anualIncome, healthExpends));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employeeQuantity = int.Parse(Console.ReadLine());

        taxPayers.Add(new Company(name, anualIncome, employeeQuantity));
    }
}

Console.WriteLine("");
Console.WriteLine("TAXES PAID:");
double totalTax = 0;
foreach (TaxPayer payer in taxPayers)
{
    Console.WriteLine(payer);
    totalTax += payer.TaxCalc();
}

Console.WriteLine("");
Console.WriteLine($"TOTAL TAXES: ${totalTax.ToString("F2", CultureInfo.InvariantCulture)}");