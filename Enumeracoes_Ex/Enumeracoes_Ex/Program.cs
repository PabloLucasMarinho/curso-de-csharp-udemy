using System.Globalization;
using Enumeracoes_Ex.Entities;
using Enumeracoes_Ex.Entities.Enums;

Console.WriteLine("Enter client data:");
string name, email, dateString, productName;
bool isStatusValid;
int itemsQuantity, productQuantity;
double productPrice;
OrderStatus status;
DateTime date;
do
{
    Console.Write("Name: ");
    name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Invalid value! Field name must not be empty.");
    }
} while (string.IsNullOrEmpty(name));


do
{
    Console.Write("Email: ");
    email = Console.ReadLine();
    if (string.IsNullOrEmpty(email))
    {
        Console.WriteLine("Invalid value! Field email must not be empty.");
    }
} while (string.IsNullOrEmpty(email));

Func<string, bool> isDateValid = isDateValidString => 
    DateTime.TryParseExact(
        isDateValidString, 
        "dd/MM/yyyy", 
        CultureInfo.InvariantCulture, 
        DateTimeStyles.None, 
        out _
    );

do
{
    Console.Write("Birth date (DD/MM/YYYY): ");
    dateString = Console.ReadLine();
    if (!isDateValid(dateString))
    {
        Console.WriteLine("Invalid value! Please, enter a date on format DD/MM/YYYY.");
    }
} while (!isDateValid(dateString));
date = DateTime.Parse(dateString);

Client client = new(name, email, date);

Console.WriteLine("Enter order data:");
do
{
    Console.Write("Status (PendingPayment / Processing / Shipped / Delivered): ");
    isStatusValid = Enum.TryParse(Console.ReadLine(), true, out status) && Enum.IsDefined(typeof(OrderStatus), status);

    if (!isStatusValid)
    {
        Console.WriteLine("Invalid value! Please, enter PendingPayment, Processing, Shipped or Delivered");
    }
}while (!isStatusValid);

Order order = new(status, client);

Console.Write("How many items to this order? ");
itemsQuantity = int.Parse(Console.ReadLine());
for (int i = 0; i < itemsQuantity; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data:");
    do
    {
        Console.Write("Product name: ");
        productName = Console.ReadLine();
        if (string.IsNullOrEmpty(productName))
        {
            Console.WriteLine("Invalid value! Field name must not be empty.");
        }
    } while (string.IsNullOrEmpty(productName));

    Console.Write("Product price: $");
    productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantity: ");
    productQuantity = int.Parse(Console.ReadLine());

    Product product = new(productName, productPrice);
    OrderItem item = new(productQuantity, product);
    order.AddItem(item);
}

Console.WriteLine(order);