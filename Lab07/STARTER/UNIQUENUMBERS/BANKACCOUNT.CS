
class BankAccount 
{
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
    
    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal put)
    {
        if (put > 0)
            accBal += put;    
        return accBal;
    }

    public bool Withdraw(decimal take)
    {
        bool sufficientFunds = accBal >= take;
        if (sufficientFunds)
            accBal -= take;
        return sufficientFunds;
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 1000;
}
