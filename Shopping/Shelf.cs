using System;
using System.Collections.Generic;
using System.Globalization;
using SalesTaxes.Models;

namespace SalesTaxes.Shopping
{
    public class Shelf
    {

        private readonly Dictionary<string, Product> products;

        public Shelf()
        {
            products = new Dictionary<string, Product>();
            AddToShelf("book", new Book());
            AddToShelf("music cd", new Other());
            AddToShelf("chocolate bar", new Food());
            AddToShelf("box of chocolates", new Food());
            AddToShelf("bottle of perfume", new Other());
            AddToShelf("packet of headache pills", new Medical());
        }

        public void AddToShelf(string item, Product category)
        {
            products.Add(item, category);
        }

        public Product Search(string name, double price, bool isImport, int quantity)
        {
            Product product = products[name.ToLower()].GetFactory().CeateProduct(name, price, isImport, quantity);
            return product;
        }




    }
}