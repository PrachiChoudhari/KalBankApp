using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    public class Account
    {
        #region statics
        private static int lastAccountNumber = 0;
           
        #endregion



        #region Properties
        public int AccountNumber { get; private set; }
        public string EmailAdress { get; set; }

        /// <summary>
        /// Balance amount in the bank for this account
        /// </summary>
        public decimal Balance { get; private set; }

        public string AccountType { get; set; }
        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Constructor
        public Account()
        {
            
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposit Money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
           // Balance = Balance + amount;
            Balance += amount;
        }

        public void withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
