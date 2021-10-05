using SalesTaxes.Factories;
using SalesTaxes.TaxCalculations;

namespace SalesTaxes.Models
{
    public class Medical : Product
    {
        public Medical() : base()
        {

        }

        public Medical(string name, double price, bool isImported, int qty) : base(name, price, isImported, qty)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new MedicalFactory();
        }

        public override double GetTax()
        {
                return TaxValues.MEDICAL_TAX;
        }


    }
}