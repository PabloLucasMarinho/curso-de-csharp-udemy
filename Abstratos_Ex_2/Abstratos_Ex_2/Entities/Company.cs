namespace Abstratos_Ex_2.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeQuantity { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int employeeQuantity) : base(name, anualIncome)
        {
            EmployeeQuantity = employeeQuantity;
        }

        public override double TaxCalc()
        {
            if (EmployeeQuantity > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
