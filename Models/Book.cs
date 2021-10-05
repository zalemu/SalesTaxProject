using SalesTaxes.Factories;
using SalesTaxes.TaxCalculations;

namespace SalesTaxes.Models
{
    public class Book : Product
    {
        public Book() : base()
        {
        }

        public Book(string name, double price, bool isImported, int qty) : base(name, price, isImported, qty)
        {

        }

        public override ProductFactory GetFactory()
        {
            return new BookFactory();
        }

        public override double GetTax()
        {
            return TaxValues.BOOK_TAX;
        }




    }
}