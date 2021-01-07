using InterfaceCarRental.Entities;
using System;

namespace InterfaceCarRental.Service
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, BrazilTaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental rental)
        {
            TimeSpan duration = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;

            if (basicPayment <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            rental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
