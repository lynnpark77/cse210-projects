public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }
        if ( Address InUsa() = true)
        {
            totalCost += 5;
            return totalCost;
        }
        else
        {
            totalCost += 35;
            return totalCost;
        }
    }
    public string GetPackingLabel()
    {
        string packingLabel ="";
        foreach (Product product in _products)
        {
          packingLabel += $"{product.GetPackingInfo()}";
        }
        return packingLabel;
        
    }
    public string GetShippingLabel()
    {
        return $"{_customerName} {GetAddress()}";
    }
}