using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

Console.WriteLine("Enter rental data:");
Console.Write("Car model: ");
string model = Console.ReadLine();

Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Return (dd/mm/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: $");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter price per day: $");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new(start, finish, new Vehicle(model));

RentalService rentalService = new(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("");
Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);