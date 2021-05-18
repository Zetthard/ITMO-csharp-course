using System;
using System.IO;
using System.Collections;

sealed class BankAccount: IDisposable 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
	private Queue tranQueue = new Queue();
    private bool disposed = false;
    
    private static long nextNumber = 123;

	// Constructors
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
	    accBal = 0;
    }

    public BankAccount(AccountType aType)
	{
		accNo = NextNumber();
		accType = aType;
		accBal = 0;
	}

	public BankAccount(decimal aBal)
	{
		accNo = NextNumber();
		accType = AccountType.Checking;
		accBal = aBal;
	}

	public BankAccount(AccountType aType, decimal aBal)
	{
		accNo = NextNumber();
		accType = aType;
		accBal = aBal;
	}

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
			BankTransaction tran = new BankTransaction(-amount);
			tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
		BankTransaction tran = new BankTransaction(amount);
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

    public void Dispose()
    {
        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number: {0}", accNo);
            swFile.WriteLine("Account Type: {0}", accType);
            swFile.WriteLine("Account balance: {0}", accBal);
            swFile.WriteLine("Transactions: {0}");
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Amount: {0}\tDate/Time: {1}", tran.Amount(), tran.When());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    ~BankAccount()
    {
        // finalizes object if Dispose() was not called
    }
}
