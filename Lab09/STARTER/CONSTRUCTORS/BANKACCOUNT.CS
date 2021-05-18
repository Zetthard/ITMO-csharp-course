using System.Collections;

class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();
    
    private static long nextNumber = 123;

    public BankAccount()
    {
        accNo = NextNumber();
        accBal = 0;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accBal = 0;
        accType = aType;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accBal = aBal;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accBal = aBal;
        accType = aType;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) 
        {
            accBal -= amount;
            BankTransactions tran = new BankTransactions(-amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransactions tran = new BankTransactions(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }
    public Queue Transactions()
    {
        return tranQueue;
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
        return nextNumber++;
    }
}
