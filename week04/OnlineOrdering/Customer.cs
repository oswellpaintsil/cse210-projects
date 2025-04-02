public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Location()
    {
        return _address.GetLocation();
    }

    public string ShippingLabel()
    {
        string slabel = $"CUSTOMER:\n{_name}\nADDRESS:\n{_address.FullAddress()}\n";
        return slabel;
    }
}