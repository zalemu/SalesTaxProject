using System.Collections.Generic;
using SalesTaxes.Interfaces;
using SalesTaxes.Models;
using SalesTaxes.Shopping;
using SalesTaxes.TaxCalculations;

namespace SalesTaxes.Bills
{
    public class Payment
    {
        private Biller biller;
        private Receipt receipt;
        private List<Product> products;
        TaxCalculatorFactory factory;
        public Payment()
        {
            factory = new TaxCalculatorFactory();
            biller = new Biller(factory.GetTaxCalculator());
        }

        public void BillItemsInCart(Cart cart)
        {
            products = cart.GetItemsFromCart();

            foreach (Product p in products)
            {
                double tax = biller.CalculateTax(p.Price, p.GetTax(), p.IsImported);
                double taxedCost = biller.CalcTotalProductCost(p.Price, tax);
                p.TotalCost = taxedCost;
            }
        }

        public Receipt GetReceipt()
        {
            double totalTax = biller.CalcTotalTax(products);
            double totalAmount = biller.CalcTotalAmount(products);
            receipt = biller.CreateNewReceipt(products, totalTax, totalAmount);
            return receipt;
        }

        public void PrintReceipt(Receipt receipt)
        {
            biller.GenerateReceipt(receipt);
        }





    }
}