using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    private const decimal shippingCostUSA = 5.00m;
    private const decimal shippingCostInternational = 35.00m;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    
    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.GetTotalCost();
        }

        
        decimal shippingCost = customer.IsFromUSA() ? shippingCostUSA : shippingCostInternational;
        totalPrice += shippingCost;

        return totalPrice;
    }

    
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetFullAddress()}\n";
    }
}
