public class Order
{
    private List<Product> _products { get; set; } = new List<Product>();
    private Customer _customer { get; set; }

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        // Shipping cost: $5 if in the USA, $35 if not
        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public void DisplayShippingLabel()
    {
        System.Console.WriteLine($"Shipping Label:");
        _customer.DisplayCustomerInfo();
    }
}