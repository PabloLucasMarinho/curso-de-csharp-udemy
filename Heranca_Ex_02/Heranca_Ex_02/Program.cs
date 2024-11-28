using System.Globalization;
using Heranca_Ex_02.Entities;

List<Product> products = [];

Console.Write("Enter the number of products: ");
int quantity = int.Parse(Console.ReadLine());

for (int i = 1;  i <= quantity; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char response = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: $");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Product product;

    if (response == 'u')
    {
        Console.Write("Manufactured date: (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        product = new UsedProduct(name, price, date);
    }else if (response == 'i')
    {
        Console.Write("Customs fee: $");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        product = new ImportedProduct(name, price, customsFee);
    }else
    {
        product = new(name, price);
    }

    products.Add(product);
}

Console.WriteLine("");
Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}