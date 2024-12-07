using System;
using System.Collections.Generic;
public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer name, Address address)
    {
        _customer = name;
        _products = new List<Product>();
    
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0m;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }

        decimal shippingCost = 0m;
        if (_customer.IsUSA())
        {
            shippingCost = 5m;
        }
        else
        {
            shippingCost = 35m;
        }
        totalCost += shippingCost;
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel ="";
        foreach (Product product in _products)
        {
          packingLabel +=$"{product.GetPackingInfo()}\n";
        }
        return packingLabel;
        
    }
    public string GetShippingLabel(Customer name, Address address)
    {
        return $"Customer: {name.GetName()}\n{address.GetAddress()}";
    }
}