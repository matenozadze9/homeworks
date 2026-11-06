using System;

namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount current = new CurrentAccount();
            current.AccountNumber = "GE29NB0000000123456789";
            current.Balance = 1500.50;
            current.OverdraftLimit = 500;
            current.PrintInfo();

            Console.WriteLine();

            DepositAccount deposit = new DepositAccount();
            deposit.AccountNumber = "GE29NB0000000987654321";
            deposit.Balance = 5000;
            deposit.CardNumber = "1234567890123456";
            deposit.ExpiryDate = "12/28";
            deposit.PrintInfo();
        }
    }
}