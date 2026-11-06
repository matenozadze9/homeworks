using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace homework8
{
    class Account
    {
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value != null && value.Length == 22) accountNumber = value;
                else Console.WriteLine("Shecdoma: Angarisish nomeri unda iyos 22 simbolos sigrdis!");
            }
        }

        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0) balance = value;
                else Console.WriteLine("Shecdoma: Balansi ar sheidzleba iyos uaryofiti!");
            }
        }
    }

    class CurrentAccount : Account
    {
        private double overdraftLimit;
        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set
            {
                if (value >= 0) overdraftLimit = value;
                else Console.WriteLine("Shecdoma: OverdraftLimit ar unda iyos uaryofiti!");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("--- Current Account ---");
            Console.WriteLine($"Angarishi: {AccountNumber}");
            Console.WriteLine($"Balansi: {Balance}");
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit}");
        }
    }

    class DepositAccount : Account
    {
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value != null && value.Length <= 16) cardNumber = value;
                else Console.WriteLine("Shecdoma: Baratis nomeri unda iyos maqsimum 16 cifri!");
            }
        }

        public string ExpiryDate { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("--- Deposit Account ---");
            Console.WriteLine($"Angarishi: {AccountNumber}");
            Console.WriteLine($"Balansi: {Balance}");
            Console.WriteLine($"Baratis Nomeri: {CardNumber}");
            Console.WriteLine($"Gvadi: {ExpiryDate}");
        }
    }

    class CreditAccount : Account
    {
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value != null && value.Length <= 16) cardNumber = value;
                else Console.WriteLine("Shecdoma: Baratis nomeri unda iyos maqsimum 16 cifri!");
            }
        }

        public string ExpiryDate { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("--- Credit Account ---");
            Console.WriteLine($"Angarishi: {AccountNumber}");
            Console.WriteLine($"Balansi: {Balance}");
            Console.WriteLine($"Baratis Nomeri: {CardNumber}");
            Console.WriteLine($"Gvadi: {ExpiryDate}");
        }
    }
}