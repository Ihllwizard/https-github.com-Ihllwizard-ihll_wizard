using System;

namespace BankPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initialbalance.");
            account.MakeWithdrawal(500, DataTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            //Test that the initial balance must be positive.
            try
            {
                var invalidAccount= new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            //Test for negative balance.
            try
            {
                account.MakeWithdrawal(750,DataTime.Now,"Attempt to overdraw");
            }
            catch (InvalidOPerationException e)
            {
                Console.Written("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
