using System;

public class LineOfCreditAccount : BankAccount
{
    public string accountName = "";
    public decimal initialBalance = 0;


    public LineOfCreditAccount(string accountNameSet, decimal initialBalanceSet)
    {
        accountName = accountNameSet;
        initialBalance = initialBalanceSet;
    }


}
