using SalesTaxes.Factories;
using SalesTaxes.TaxCalculations;

namespace SalesTaxes.Models
{
    public class Food : Product
    {
        public Food() : base()
        {

        }

        public Food(string name, double price, bool isImported, int qty) : base(name, price, isImported, qty)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new FoodFactory();
        }

        public override double GetTax()
        {
            return TaxValues.FOOD_TAX;
        }

    }
}