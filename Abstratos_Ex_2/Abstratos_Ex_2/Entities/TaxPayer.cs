using System.Globalization;

namespace Abstratos_Ex_2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() { }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxCalc();

        public override string ToString()
        {
            return $"{Name}: ${TaxCalc().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
