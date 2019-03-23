using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    static class Bank
    {
        /// <summary>
        /// Create a bank account
        /// </summary>
        /// <param name="emailAddress">Email address for the account</param>
        /// <param name="accountType">Checking or Savings</param>
        /// <param name="initialDeposit">Amount to deposit</param>
        /// <returns></returns>
        public static Account CreateAccount(string emailAddress, string accountType, decimal initialDeposit)
        {
            var account = new Account
            {
                EmailAdress = emailAddress,
                AccountType = accountType,
            };

            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);                
            }

            return account;
        }
    }
}
