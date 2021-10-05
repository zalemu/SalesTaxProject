using System;
using SalesTaxes.Bills;
using SalesTaxes.Models;

namespace SalesTaxes.Shopping
{
    public class Store
    {
        private Cart cart;
        private Shelf shelf;
        private Payment payment;
      
        public Store()
        {
            cart = new Cart();
            payment = new Payment();
            shelf = new Shelf();
        }


        public void GetOrder()
        {
            do
            {
                string name = GetName();
                double price = GetPrice();
                bool isImport = IsImported();
                int quantity = GetQuantity();
                AddToCart(name, price, isImport, quantity);
            }
            while (IsContinue());
        }

        public void AddToCart(string name, double price, bool isImport, int quantity)
        {
            Product product = shelf.Search(name, price, isImport, quantity);
            cart.AddItemToCart(product);
        }

        public string GetName()
        {
            Console.WriteLine("Enter the product name");
            return Console.ReadLine();
        }

        public double GetPrice()
        {
            Console.WriteLine("Enter the product price");
            var input = Console.ReadLine();
            double val;
            while (!(double.TryParse(input, out val)))
            {
                Console.WriteLine("Invalid price. Enter a number");
            }

            return val;
        }

        public bool IsImported()
        {

        start:
            Console.WriteLine("Is product imported?(Y/N)");
            var input = Console.ReadLine();
            bool isValid = false;
            while (!isValid)
            {
                if (input.ToUpper() == "Y")
                    isValid = true;
                else if (input.ToUpper() == "N")
                    isValid = true;
                else
                {
                    Console.WriteLine("Invalid input. Enter (Y/N)");
                    goto start;
                }
            }

            if (input.ToUpper() == "Y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a integer");
            }
            return intVal;
        }



        public bool IsContinue()
        {
            Console.WriteLine("Do you want to add another Product?(Y/N)");
            var input = Console.ReadLine();
            while (!(input.ToUpper() == "Y" || input.ToUpper() == "N"))
            {
                Console.WriteLine("Invalid input. Enter (Y/N)");
            }
            if (input.ToUpper() == "Y")
                return true;
            else
                return false;
        }

        public void CheckOut()
        {
            payment.BillItemsInCart(cart);
            Receipt receipt = payment.GetReceipt();
            payment.PrintReceipt(receipt);
        }




    }
}