using SalesTaxes.Models;

namespace SalesTaxes.Factories
{
    public class OtherFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool isImported, int qty)
        {
            return new Other(name, price, isImported, qty);
        }
    }
}