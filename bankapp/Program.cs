using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account();
                     
            a1.EmailAdress = "test@test.com";
            a1.AccountType = "Checking";

            Console.WriteLine($"AN: { a1.AccountNumber}, B: {a1.Balance}, CD: {a1.CreatedDate}, EA: {a1.EmailAdress}, AT: {a1.AccountType}");


            var a2 = new Account();

            a2.EmailAdress = "test1@test.com";
            a2.AccountType = "Savings";

            Console.WriteLine($"AN: { a2.AccountNumber}, B: {a2.Balance}, CD: {a2.CreatedDate}, EA: {a2.EmailAdress}, AT: {a2.AccountType}");
        }



    }
}
