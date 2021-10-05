using System;
using SalesTaxes.Models;

namespace SalesTaxes.Factories
{
    public abstract class ProductFactory
    {
        public abstract Product CeateProduct(string name, double price, bool isImported, int qty);
    }
}