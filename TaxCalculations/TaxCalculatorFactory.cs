using System.Collections.Generic;
using SalesTaxes.Interfaces;

namespace SalesTaxes.TaxCalculations
{
    public class TaxCalculatorFactory
    {
        private readonly ITaxCalculator taxCalculator;
        public TaxCalculatorFactory()
        {
            taxCalculator = new TaxCalculator();
        }

        public ITaxCalculator GetTaxCalculator()
        {
            return taxCalculator;
        }


    }
}