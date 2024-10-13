public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalPrice()
    {
        int shippingCost;
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.TotalProductCost();
        }
        if (_customer.GetAddress().IsUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double totalCost = totalProductCost + shippingCost;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductString() + "\n";
        }
        packingLabel += $"Total Price: ${GetTotalPrice()}";
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.DisplayCustomer();
        return shippingLabel;
    }
}