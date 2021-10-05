using SalesTaxes.Factories;

namespace SalesTaxes.Models
{
    public abstract class Product
    {
        protected string Name { get; set; }
        public bool IsImported { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        private double _price;
        public double Price
        {
            set { _price = value; }
            get { return _price * Quantity; }
        }

        public Product()
        {
            this.Name = string.Empty;
            this.Price = 0.0;
            this.IsImported = false;
            this.Quantity = 0;
            this.TotalCost = 0.0;
        }

        public Product(string name, double price, bool imported, int qty)
        {
            this.Name = name;
            this.Price = price;
            this.IsImported = imported;
            this.Quantity = qty;
        }

        public override string ToString()
        {
            return (Quantity + (IsImported == true ? " imported" : " ") + Name + " : " + TotalCost);
        }

        public abstract ProductFactory GetFactory();

        public abstract double GetTax();


    }
}