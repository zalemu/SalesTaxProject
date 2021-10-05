using System.Collections.Generic;
using SalesTaxes.Models;
using SalesTaxes.TaxCalculations;
using System;
using SalesTaxes.Interfaces;

namespace SalesTaxes.Bills
{
    public class Biller
    {
        ITaxCalculator taxCalculator;

        public Biller(ITaxCalculator taxCalc)
        {
            taxCalculator = taxCalc;
        }

        public double CalculateTax(double price, double tax, bool imported)
        {

            double totalProductTax = taxCalculator.CalculateTax(price, tax, imported);
            return totalProductTax;
        }

        public double CalcTotalProductCost(double price, double tax)
        {
            return FormatValue(price + tax);
        }

        public double CalcTotalTax(List<Product> prodList)
        {
            double totalTax = 0.0;

            foreach (Product p in prodList)
            {
                totalTax += (p.TotalCost - p.Price);
            }
            return FormatValue(totalTax);
        }

        public double CalcTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            foreach (Product p in prodList)
            {
                totalAmount += p.TotalCost;
            }

            return FormatValue(totalAmount);
        }

        public Receipt CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }

        public void GenerateReceipt(Receipt r)
        {
            String receipt = r.ToString();
            Console.WriteLine(receipt);
        }

        private double FormatValue(double value)
        {
            return Double.Parse(value.ToString("N2"));
        }







    }
}