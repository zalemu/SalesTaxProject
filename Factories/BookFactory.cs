using SalesTaxes.Models;

namespace SalesTaxes.Factories
{
    public class BookFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool isImported, int qty)
        {
            return new Book(name, price, isImported, qty);
        }
    }
}