using Interfaces_Ex_01.Entities;

namespace Interfaces_Ex_01.Services
{
    internal class OnlinePaymentService(ITaxService taxService)
    {
        private ITaxService _taxService = taxService;

        public void ProcessPayment(Contract contract, int months)
        {
            double basicQuota = contract.Value / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _taxService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _taxService.PaymentFee(updatedQuota);
                contract.AddInstallment(new(date, fullQuota));
            }
        }
    }
}
