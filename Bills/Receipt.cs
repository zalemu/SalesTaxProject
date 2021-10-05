using System.Collections.Generic;
using SalesTaxes.Models;
using System;
namespace SalesTaxes.Bills
{
    public class Receipt
    {
        private List<Product> ProductList { get; set; }
        private double TotalSalesTax { get; set; }
        private double TotalAmount { get; set; }

        public Receipt(List<Product> prod, double tax, double amount)
        {
            ProductList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }

        public override string ToString()
        {
            string receipt = "";
            Console.WriteLine("***************");
            foreach (var p in ProductList)
            {
                receipt += (p.ToString() + "\n");
            }

            receipt += "Sales tax = " + TotalSalesTax + "\n";
            receipt += "Total = " + TotalAmount + "\n";

            return receipt;
        }
    }
}