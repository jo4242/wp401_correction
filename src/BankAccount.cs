namespace BankAccountApp;

public class BankAccount
{
private string _accountnumber;
private Person _accountholder;
private float _balance;

    public string Accountnumber
    {
        get
        {
            return _accountnumber;
        }
    }

    public Person Accountholder
    {
        get
        {
            return _accountholder;
        }
    }

    public float Balance
    {
        get
        {
            return _balance;
        }
    }

    public BankAccount (string Accountnumber, Person AccounHolder, float Balance) {
        _accountnumber = Accountnumber;
        _accountholder = AccounHolder;
        _balance = Balance;
    }
    

    
    public void Deposit(float amount)
    {
        _balance += amount;
    }

    public void Withdraw(float amount)
    {
        if(_balance - amount >= 0) {
            _balance -= amount;
        }
    }
    
    public void Transfer(float amount, Person AccountToTransferTo)
    {
        Withdraw(amount);
        AccountToTransferTo.Deposit(amount);

    }

    public string PrintAccountInfo()
    {
        return _accountnumber + " " + _accountholder + " " + _balance;
    }

    private bool CheckLiquidity()
    {
        if(_balance < 0 ){
            return true;
        } else {
            return false;
        }
    }
}
