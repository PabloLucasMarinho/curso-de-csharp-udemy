using System.Globalization;
using Excecoes_Ex_02.Entities;
using Excecoes_Ex_02.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data:");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string name = Console.ReadLine();
    Console.Write("Initial balance: $");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: $");
    double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new(number, name, balance, limit);

    Console.WriteLine("");
    Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(withdraw);

    Console.WriteLine(account);
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (FormatException)
{
    Console.WriteLine("Format error: Invalid input.");
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}