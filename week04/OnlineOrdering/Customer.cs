public class Customer
{
    private string _name { get; set; }
    private Address _address { get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {_name}");
        Console.WriteLine("Address:");
        Console.WriteLine(_address.GetFullAddress());
        Console.WriteLine($"Lives in USA? {LivesInUSA()}");
        Console.WriteLine();
    }
}