using System.Runtime.CompilerServices;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public bool IsAmerican() //LOL
    {
        if (_country == "USA" || _country == "American" || _country == "United States")
        {
            return true;
            
        }
        else
        {
            return false;
        }
    }
}