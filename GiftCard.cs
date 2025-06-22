using System;

public class GiftCardAccount : BankAccount
{
    public string accountName = "";
    public decimal initialBalance = 0;

    public GiftCardAccount(string accountNameSet, decimal initialBalanceSet)
    {
        accountName = accountNameSet;
        initialBalance = initialBalanceSet;
    }
}
