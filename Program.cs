using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Etienne", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} as the initial balance.");
        }
    }
}
