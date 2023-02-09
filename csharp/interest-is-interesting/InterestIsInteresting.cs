using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = 0f;
        if (balance < 0)
            interestRate = 3.213f;
        else if (balance is >= 0 and < 1000m) 
        //else if (balance >= 0 && balance < 1000m)
            interestRate = .5f;
        else if (balance is >= 1000m and < 5000m)
            interestRate = 1.621f;
        else if (balance >= 5000m)
            interestRate = 2.475f;

        return interestRate;
    }
    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance)/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + (Interest(balance));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0; 
        while (balance <= targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }

        return years; 
    }
}
