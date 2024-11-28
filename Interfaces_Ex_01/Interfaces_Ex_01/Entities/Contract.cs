namespace Interfaces_Ex_01.Entities
{
    internal class Contract(int number, DateTime date, double value)
    {
        public int Number { get; set; } = number;
        public DateTime Date { get; set; } = date;
        public double Value { get; set; } = value;
        public List<Installment> Installments { get; set; } = [];

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
