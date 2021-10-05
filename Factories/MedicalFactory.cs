using SalesTaxes.Models;

namespace SalesTaxes.Factories
{
    public class MedicalFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool isImported, int qty)
        {
            return new Medical(name, price, isImported, qty);
        }
    }
}