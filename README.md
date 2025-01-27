[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/629BT2k4)
# Bank Account OOP Exercise

This exercise is designed to help you practice object-oriented programming (OOP) concepts in C#. You will create a simple bank account application.

## Objectives

- Understand and implement classes and objects
- Understand and implement fields
- Use properties and methods
- Apply encapsulation principles

## Instructions

1. **Create a `Person` class:**
  - Fields:
    - `FirstName` (string)
    - `LastName` (string)
    - `Address` (Address)
    - `Birthday` (DateTime)
  - Methods:
    - `GetFullName()`: Returns the full name of the person.
    - `GetAge()`: Returns the age of the person based on the current date and their birthday.

2. **Create an `Address` class:**
  - Fields:
    - `Street` (string)
    - `City` (string)
    - `State` (string)
    - `PostalCode` (string)

3. **Create a `BankAccount` class:**
  - Properties:
    - `AccountNumber` (string)
    - `AccountHolder` (Person)
    - `Balance` (decimal)
  - Methods:
    - Pubilc Method:
      - `Deposit(decimal amount)`: Adds the specified amount to the account balance.
      - `Withdraw(decimal amount)`: Deducts the specified amount from the account balance if sufficient funds are available.
      - `Transfer(...)`: Transfers the specified amount to another bank account.
      - `PrintAccountInfo()`: Prints the account number, account holder's full name, and current balance.
    - Private Method:
      - `CheckLiquidity(decimal amount)`: Checks if the account has sufficient funds for a withdrawal, considering special conditions for youth accounts.

4. **Implement the following functionality:**
  - Create instances of `BankAccount`, `Person` and `Address`
  - Perform deposit and withdrawal operations
  - Handle overdraft in the checking account
  - Transfer funds between accounts


## Shell Commands

```sh
dotnet new sln -n "BankAccount"
dotnet new classlib -o src -n BankAccount.Models
dotnet sln "BankAccount.sln" add "src/BankAccount.Models.csproj"
dotnet new console -o samples -n BankAccountApp --use-program-main
dotnet sln "BankAccount.sln" add "samples/BankAccountApp.csproj"
dotnet add "samples/BankAccountApp.csproj" reference "src/BankAccount.Models.csproj"
```

## C# Coding Standards and Naming Conventions
The following **Naming Conventions** must be followed: 
[C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)

For more information on coding standards, see: 
[Common C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)


## Documentation comments
Document your code with XML comments, like in the example below.

```csharp
/// <summary>
/// Adds the specified amount to the account balance.
/// </summary>
/// <param name="amount">The amount to deposit.</param>
public void Deposit(decimal amount)
{
  // code
}
```

## Submission

1. **Collaborate using Visual Studio Code Live Share:**
  - Open your project in Visual Studio Code.
  - Use the Live Share extension to collaborate with your partner.
  - Share your code and work together to complete the exercise.

2. **Submit to Git Repository:**
  - Use the GUI as in the previous workpages to push or changes or:
    - Add your files to the repository:
      ```sh
      git add .
      ```
    - Commit your changes:
      ```sh
      git commit -m "Initial commit for Bank Account OOP Exercise"
      ```
    - Push your changes to a remote repository:
      ```sh
      git push -u origin main
      ```

## Additional Notes

- Ensure that all classes are properly encapsulated, with private fields and public properties.
- Use meaningful variable names and follow the C# coding standards and naming conventions.
- Test your methods thoroughly to ensure they work as expected.
- Handle exceptions gracefully, especially when dealing with invalid operations like overdrafts.
- Use comments to explain the purpose of your code and any complex logic.
- Collaborate effectively with your partner using Visual Studio Code Live Share to share ideas and solve problems together.
- Regularly commit your changes to the Git repository to keep track of your progress and collaborate efficiently.
- Refer to the provided links for more information on fields, properties, methods, constructors, and DateTime in C#.


- [Fields](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields)
- [Properties](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- [Constructors](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-9.0)

**Happy coding without Copilot or ChatGPT!**