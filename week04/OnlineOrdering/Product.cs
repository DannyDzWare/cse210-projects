public class Product
{
    #region internal Variables
    private string _name { get; set; }
    private int _productId { get; set; }
    private double _price { get; set; }
    private int _quantity { get; set; }

    #endregion
    
    #region external Variables
    public string Name{
        get{ return _name;}
    }

    public int ProductId{
        get{ return _productId;}
    }
    #endregion
    
    #region Constructor
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    #endregion
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Price per unit: ${_price}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total Cost: ${GetTotalCost()}");
        Console.WriteLine();
    }
}