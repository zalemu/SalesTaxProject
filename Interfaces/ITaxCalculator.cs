namespace SalesTaxes.Interfaces
{
    public interface ITaxCalculator
    {
        double CalculateTax(double price, double tax, bool isImported);
    }
}