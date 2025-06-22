using System;

public class InterestEarningAccount : BankAccount
{
    public string accountName = "";
    public decimal initialBalance = 0;

    public InterestEarningAccount(string accountNameSet, decimal initialBalanceSet)
    {
        accountName = accountNameSet;
        initialBalance = initialBalanceSet;
    }


    public override void MakeDeposit(decimal addToBalance)
    {
        initialBalance += addToBalance;
    }

    public override void MakeWithdrawal(decimal deductFromBalance)
    {
        initialBalance += deductFromBalance;
    }


    public override void PerformMonthEndTransactions() 
    {
        Console.WriteLine("Account Balance in IA Account" + initialBalance);
        Console.WriteLine("override from InterestEarningAccount");
    }
}
