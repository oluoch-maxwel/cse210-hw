using System;
using System.Collections.Generic;

public class Order
{
    private List<Product>_product;
    private Customer _customer;


    public Order(Customer customer)
    { 
      _customer = customer;
      _product = new List<Product>();
    
    }

    public double GetTotalCost()
    {
      double total = 0;
      foreach(Product p in _product)
      {
        total += p.GetTotalCost();
      }

    // Add shipping cost
    if(_customer.IsInUsa())
    {
       total += 5;
    }
    else
    {
      total += 35;
    }

    return total;
    }

   public string GetPackagingLabel()
  {
    string p_label = "";
    foreach(Product pro in _product)
    {
      p_label += $"{pro.GetName()} - {pro.GetProductId()}\n";
    }
    return p_label;
  }

  public string GetShippingLabel()
    {

      string slabel = "";

      slabel += $"{_customer.GetName()}\n";
      slabel += $"{_customer.GetAddress()}";

      return slabel;
    }

public void AddProduct(Product product)
{
    _product.Add(product);
}
}