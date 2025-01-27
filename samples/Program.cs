namespace BankAccountApp;

class Program
{
    static void Main(string[] args)
    {
        string? Firstname;
        string? Lastname;
        string? street;
        string? city;
        string? state;
        string? postalCode;
        
        Console.Write("Firstname: ");
        Firstname = Console.ReadLine();

        Console.Write("Lastname: ");
        Lastname = Console.ReadLine();

        Console.Write("Street: ");
        street = Console.ReadLine();

        Console.Write("City: ");
        city = Console.ReadLine();

        Console.Write("State: ");
        state = Console.ReadLine();

        Console.Write("Postal Code: ");
        postalCode = Console.ReadLine();

        Console.Write("Birthday: ");
        DateTime Birthday = Convert.ToDateTime(Console.ReadLine());

        Address address1 = new Address(street, city, state, postalCode);

        Person person1  = new Person(Firstname, Lastname, address1, Birthday);

        Address address2 = new Address("Musterdorf", "Musterstadt", "MusterLand", "1000");

        Person person2 = new Person("John", "Doe", address2, new DateTime(2008, 11, 30));

        BankAccount account1 = new BankAccount("100", person1, 0);
        BankAccount account2 = new BankAccount("101", person2, 0);

        Console.WriteLine("---- ac1 deposit ----");

        Console.WriteLine($"ac1 balance: {account1.Balance}");
        account1.Deposit(1000);
        Console.WriteLine($"ac1 balance: {account1.Balance}");

        Console.WriteLine("---- ac1 transfer to ac 2 ----");

        account1.Transfer(100, account2);

        Console.WriteLine($"ac1 balance: {account1.Balance}");
        Console.WriteLine($"ac2 balance: {account2.Balance}");

        Console.WriteLine("---- ac1 widthdraw ----");
        account1.Withdraw(900);
        Console.WriteLine($"ac1 balance: {account1.Balance}");
    }
}
