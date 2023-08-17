using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("v", 1000000000);
            Console.WriteLine($"account for {account.Owner} was successfully created with ${account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "withdraw");
            Console.WriteLine(account.Balance);
        }
    }
}