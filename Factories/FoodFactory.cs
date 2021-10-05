using SalesTaxes.Models;

namespace SalesTaxes.Factories
{
    public class FoodFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool isImported, int qty)
        {
            return new Food(name, price, isImported, qty);
        }
    }
}