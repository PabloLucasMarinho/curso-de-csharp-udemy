using System.Globalization;
using Interfaces_Ex_01.Entities;
using Interfaces_Ex_01.Services;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: $");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new(contractNumber, contractDate, contractValue);

OnlinePaymentService onlinePayment = new(new PayPalTaxService());
onlinePayment.ProcessPayment(contract, months);

Console.WriteLine("");
Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}