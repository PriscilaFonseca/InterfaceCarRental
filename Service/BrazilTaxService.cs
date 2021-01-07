using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCarRental.Service
{
    class BrazilTaxService : Tax
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.20;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
