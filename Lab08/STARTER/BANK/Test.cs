using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    public static void Main()
    {
        BankAccount firstAcc = new BankAccount();
        BankAccount secondAcc = new BankAccount();
        firstAcc.Populate(100);
        secondAcc.Populate(100);

        Console.WriteLine("Balance of {0} account {1} is {2}", firstAcc.Type(), firstAcc.Number(), firstAcc.Balance());
        Console.WriteLine("Balance of {0} account {1} is {2}", secondAcc.Type(), secondAcc.Number(), secondAcc.Balance());

        firstAcc.TransferFrom(secondAcc, 10);
        Console.WriteLine("Balance of {0} account {1} after transfer is {2}", firstAcc.Type(), firstAcc.Number(), firstAcc.Balance());
        Console.WriteLine("Balance of {0} account {1} after transfer is {2}", secondAcc.Type(), secondAcc.Number(), secondAcc.Balance());

        Console.ReadKey();
    }
}
