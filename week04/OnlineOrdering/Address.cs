public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _state = stateOrProvince;
        _country = country;
    }

    public string GetLocation()
    {
        if (_country == "USA")
        {
            return _country;
        }
        else
        {
            return "not in USA";
        }    
    }

    public string FullAddress()
    {
        string fulladd = $"{_street}\n{_city}\n{_state}\n{_country}";
        return fulladd;
    }

}