using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    
    public double TotalCostOfOrder()
    {
        double tCost = 0;
        foreach (Product product in _products)
        {
            tCost = tCost + product.TotalCost();
        }

        if (_customer.Location() == "USA")
        {
            tCost = tCost + 5;
        }
        else
        {
            tCost = tCost + 35;
        }
        return tCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine(_customer.ShippingLabel());
        foreach (Product product in _products)
        {
            Console.WriteLine(product.PackingLabel());
            Console.WriteLine();
        }
    }
}