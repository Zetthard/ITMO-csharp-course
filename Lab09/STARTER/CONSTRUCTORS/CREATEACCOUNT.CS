
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(AccountType.Deposit);
        BankAccount acc3 = new BankAccount(100);
        BankAccount acc4 = new BankAccount(AccountType.Deposit, 200);

        acc1.Deposit(350);
        acc2.Deposit(220);
        acc3.Deposit(230);
        acc4.Withdraw(50);
        acc1.Deposit(50);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
        Console.ReadKey();
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransactions tran in acc.Transactions())
        {
            Console.WriteLine("Amount: {0}\tDate/Time: {1}", tran.Amount(), tran.When());
        }
        Console.WriteLine();
    }
}
