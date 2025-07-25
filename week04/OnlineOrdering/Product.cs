public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        if (price < 0 || quantity < 0)
            throw new ArgumentException("Price and quantity must be positive");

        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost() => _price * _quantity;
    public string GetName() => _name;
    public string GetProductId() => _productId;
}