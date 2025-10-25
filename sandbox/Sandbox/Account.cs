class Account
{
    //define variables/attributes for an account
    private string _accountId = "001";
    private double _accountAmount = 20.21;
    private string _accountName = "asdf-qwerty";

    //set up the attributes without compromising privacy<3
    public Account(string accountId, double accountAmount, string accountName)
    {
        this._accountId = accountId;
        this._accountAmount = accountAmount;
        this._accountName = accountName;
    }

    //deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _accountAmount += amount;
        }
        else
        {
            Console.WriteLine("deposit must be greater than 0.00!");

        }
    }

    //view account
    public void ViewAccount()
    {
        Console.WriteLine($"{_accountId} | {_accountAmount} | {_accountName}");
    }


}

