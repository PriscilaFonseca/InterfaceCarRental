﻿using System;
using System.Globalization;

namespace InterfaceCarRental.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"INVOICE:\nBasic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
