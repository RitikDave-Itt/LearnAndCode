using ATM.Exceptions;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Database
{
    public static class AccountDatabase
    {
        private static List<Account> _accounts = new List<Account>();

        static AccountDatabase()
        {
            SeedAccounts();
        }

        private static void SeedAccounts()
        {
            _accounts.Add(new Account
            {
                CardNumber = "123456789",
                Pin = "1234",
                Balance = 25000,
                DailyLimit = 20000
            });

            _accounts.Add(new Account
            {
                CardNumber = "987654321",
                Pin = "5678",
                Balance = 10000,
                DailyLimit = 15000
            });

            
        }

        public static Account FindAccountByCardNumber(string cardNumber)
        {
            var account = _accounts.FirstOrDefault(acc => acc.CardNumber == cardNumber);

            if (account == null)
            {
                throw new AccountNotFoundException(cardNumber);
            }

            return account;
        }
    }
}
