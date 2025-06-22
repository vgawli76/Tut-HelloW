using System;

public class BankAccount
{
    public string accountName;
    public decimal initialBalance;

    public BankAccount()
    {
        accountName = "";
        initialBalance = 0;

        
    }

    public BankAccount(string accountNameSet, decimal initialBalanceSet)
    {
        accountName = accountNameSet;
        initialBalance = initialBalanceSet;
    }


    public virtual void MakeDeposit(decimal addToBalance)
    {
        initialBalance += addToBalance;
    }

    public virtual void MakeWithdrawal(decimal deductFromBalance)
    {
        initialBalance += deductFromBalance;
    }


    public virtual void PerformMonthEndTransactions() 
    {
        Console.WriteLine("bank virtual function");
    }

}
