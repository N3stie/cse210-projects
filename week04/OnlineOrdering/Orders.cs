using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product ?? throw new ArgumentNullException(nameof(product)));
    }

    public double CalculateTotalCost()
    {
        double subtotal = _products.Sum(p => p.CalculateTotalCost()); 
        double shipping = _customer.LivesInPhilippines() ? 50 : 200;
        return subtotal + shipping;
    }

    public string GetPackingLabel() =>
        "PACKING LABEL:\n" + 
        string.Join("\n", _products.Select(p => $"{p.GetName()} (ID: {p.GetProductId()})"));

    public string GetShippingLabel() =>
        $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
}