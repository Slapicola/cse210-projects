public class Product
{
    private string _productName;
    private long _productId;
    private double _price;
    private int _quantity;

    public Product(string name, long id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalProductCost()
    {
        double total = _price * _quantity;
        return total;
    }

    public string GetProductString()
    {
        return $"{_productName} ID: {_productId}";
    }
}