using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        public double PricePerHour { get; private set; } = pricePerHour;
        public double PricePerDay { get; private set; } = pricePerDay;

        private ITaxService _taxService = taxService;

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new(basicPayment, tax);
        }
    }
}
