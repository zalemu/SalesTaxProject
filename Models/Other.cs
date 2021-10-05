using SalesTaxes.Factories;
using SalesTaxes.TaxCalculations;

namespace SalesTaxes.Models
{
    public class Other : Product
    {
        public Other() : base()
        {
        }
        public Other(string name, double price, bool isImported, int qty) : base(name, price, isImported, qty)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new OtherFactory();
        }

        public override double GetTax()
        {
                return TaxValues.OTHER_TAX;
        }



    }
}