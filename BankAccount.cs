using System;
using System.Collection.Generic;

namespace BankPayment
{
    public class BankAccount
    {
        public string Number {get; set;}
        public string Owner {get; set;}
        public string Balance
        {
            get
            {
                double balance=0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }

        }

    public void MakeDeposit(double amount, DateTime date, string note)
    {
        if (amount <=0)
        {
            throw new ArgumentOutRangeException(name(amount),"Amount of withdrawal must be positive");
        }
        if (Balance -amount<0)
        {
            throw new InvalidOperationException("Not suffiient fund for the withdrawal");
        }
        
        var withdrawal= new Transaction(-amount,date,note);
        allTransaction.Add(withdrawal);

    }
    public BankAccount(string name, double initialBalance)
        {
            this.Number =accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial balance");
            //this.Balance = initialBalance;

        }
        private static int accountNumberSeed =12344567890;
        private List<Transaction> allTransaction = new List<Transaction>();

        public string GetAccountHistory()
        {
            var report = new System.Text.stringBuilder();

            report.AppendLine("Date\tAmount\tnote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date>ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
    
}