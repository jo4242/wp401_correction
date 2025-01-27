namespace BankAccountApp;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _postalCode;


    public string Street 
    {
        get
        {
            return _street;
        }
    }

    public string City
    {
        get
        {
            return _city;
        }
    }

    public string State
    {
        get
        {
            return _state;
        }
    }

    public string PostalCode
    {
        get
        {
            return _postalCode;
        }
    }

/// <summary>
/// 
/// </summary>
/// <param name="street"></param>
/// <param name="city"></param>
/// <param name="state"></param>
/// <param name="postalCode"></param>
    public Address(string street, string city, string state, string postalCode) 
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
    }
}