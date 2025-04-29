using ATM.Exceptions;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    public class ATMService
    {
        private ATMMachine _atm;
        private Server _server;

        public ATMService(ATMMachine atm, Server server)
        {
            _atm = atm;
            _server = server;
        }

        public void Withdraw(Account account, decimal amount)
        {
            _server.CheckServer();

            ValidateAccountNotBlocked(account);
            ValidateSufficientAccountBalance(account, amount);
            ValidateAtmHasSufficientFunds(amount);
            ValidateDailyLimitNotExceeded(account, amount);

            account.Balance -= amount;
            _atm.CashAvailable -= amount;
            account.WithdrawnToday += amount;
        }


        public bool ValidatePin(Account account, string pin)
        {
            if (account.Pin == pin)
            {
                account.InvalidAttempts = 0;
                return true;
            }

            account.InvalidAttempts++;
            if (account.InvalidAttempts >= 3)
            {
                account.IsBlocked = true;
                throw new Exception("Card blocked after 3 invalid attempts.");
            }

            return false;
        }
        private void ValidateAccountNotBlocked(Account account)
        {
            if (account.IsBlocked)
                throw new CardBlockedException("Card is blocked due to multiple invalid attempts.");
        }

        private void ValidateSufficientAccountBalance(Account account, decimal amount)
        {
            if (account.Balance < amount)
                throw new InsufficientFundsException("Insufficient balance in your account.");
        }

        private void ValidateAtmHasSufficientFunds(decimal amount)
        {
            if (_atm.CashAvailable < amount)
                throw new InsufficientFundsException("ATM has insufficient funds.");
        }

        private void ValidateDailyLimitNotExceeded(Account account, decimal amount)
        {
            if (account.WithdrawnToday + amount > account.DailyLimit)
                throw new DailyLimitExceededException("Daily withdrawal limit exceeded.");
        }
    }
}
