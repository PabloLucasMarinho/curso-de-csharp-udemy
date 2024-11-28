namespace Abstratos_Ex_2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpends { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpends) : base(name, anualIncome)
        {
            HealthExpends = healthExpends;
        }

        public override double TaxCalc()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpends * 0.5);
            }else
            {
                return (AnualIncome * 0.25) - (HealthExpends * 0.5);
            }
        }
    }
}
