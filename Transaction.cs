using System;


namespace classes
{
    public class Transaction
    {
        public double Amount {get; set;}
        public DateTime Date {get; set;}
        public string Notes {get; set;}

        public Transaction(double amount, DateTime date, string note)
        {
            this.Amount=amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}