using SalesTaxes.Interfaces;

namespace SalesTaxes.TaxCalculations
{
    public class TaxCalculator : ITaxCalculator
    {

        public double CalculateTax(double price, double tax, bool isImport)
        {
            double calculatedTax = price * tax;

            if (isImport)
                calculatedTax += (price * 0.5);

            calculatedTax = (int)(calculatedTax / 0.05 + 0.5) * 0.05;

            return calculatedTax;
        }


    }
}