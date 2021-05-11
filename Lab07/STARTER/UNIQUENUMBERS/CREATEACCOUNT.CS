
using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);

        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
    }
    
    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();
        
        //Console.Write("Enter the account number   : ");
        //long number = BankAccount.NextNumber();        

        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;
        created.Populate(balance);
        
        return created;
    }

    public static void TestDeposit(BankAccount account)
    {
        System.Console.WriteLine("Please enter amount you want to deposit: ");
        decimal amount = decimal.Parse(System.Console.ReadLine());
        account.Deposit(amount);
    }

    public static void TestWithdraw(BankAccount acc)
    {
        Console.WriteLine("Please enter desired amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (! acc.Withdraw(amount))
            Console.WriteLine("You habe insufficient funds.");
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }
}
