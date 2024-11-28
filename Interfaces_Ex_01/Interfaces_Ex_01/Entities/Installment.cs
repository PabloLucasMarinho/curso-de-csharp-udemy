using System.Globalization;

namespace Interfaces_Ex_01.Entities
{
    internal class Installment(DateTime dueDate, double amount)
    {
        public DateTime DueDate { get; set; } = dueDate;
        public double Amount { get; set; } = amount;

        public override string ToString()
        {
            return $"{DueDate:dd/MM/yyyy} - ${Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
