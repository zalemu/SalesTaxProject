using System.Collections.Generic;
using SalesTaxes.Models;

namespace SalesTaxes.Shopping
{
    public class Cart
    {
        private List<Product> products { get; set; }

        public Cart()
        {
            products = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return products;
        }

        public int CountItemsInCart()
        {
            return products.Count;
        }




    }
}