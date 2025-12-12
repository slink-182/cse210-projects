using System.Runtime.InteropServices;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //return the address as a string
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

    
}