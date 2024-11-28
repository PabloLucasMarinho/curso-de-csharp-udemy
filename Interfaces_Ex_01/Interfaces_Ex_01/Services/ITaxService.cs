namespace Interfaces_Ex_01.Services
{
    internal interface ITaxService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
