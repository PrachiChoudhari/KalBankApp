using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = Bank.CreateAccount("test@test.com", "Checking", 0);

            Console.WriteLine($"AN: { a1.AccountNumber}, B: {a1.Balance}, CD: {a1.CreatedDate}, EA: {a1.EmailAdress}, AT: {a1.AccountType}");

            var a2 = Bank.CreateAccount("test1@test.com", "Savings", 100);

            Console.WriteLine($"AN: { a2.AccountNumber}, B: {a2.Balance}, CD: {a2.CreatedDate}, EA: {a2.EmailAdress}, AT: {a2.AccountType}");
        }
    }
}
