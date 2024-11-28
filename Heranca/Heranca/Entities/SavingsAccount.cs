namespace Heranca.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Deposit(Balance * InterestRate);
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
