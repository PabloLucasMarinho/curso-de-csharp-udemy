using LINQ_Ex_01.Entities;
using System.Globalization;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\in.txt";

List<Product> products = [];

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        products.Add(new(name, price));
    }
}

var avg =
    (from p in products
     select p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach (string name in names)
{
    Console.WriteLine(name);
}