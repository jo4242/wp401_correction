namespace BankAccountApp;

public class Person
{
    private string _firstname;
    private string _lastname;
    private Address _address;
    private DateTime _birthday = new DateTime();
    private int _age;


    public string Firstname
    {
        get
        {
            return _firstname;
        }
        set
    }

    public string Lastname
    {
        get
        {
            return _lastname;
        }
    }

    public DateTime Birthday
    {
        get
        {
            return _birthday;
        }     
    }

    public int Age
    {
        get
        {
            int age = DateTime.Today.Year - _birthday.Year;

            if (_birthday > today.AddYears( - age)) {
                age--;
            } 
        }
    }

    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {
            value = _address;
        }
    }

    // Constructor
      public Person(string Firstname, string Lastname, Address address, DateTime birthday)
    {
        _firstname = Firstname;
        _lastname = Lastname;
        _address = address;
        _birthday = birthday;
    }
    
    public string GetFullName()
    {
        return _firstname + " " + _lastname;
    }

}
