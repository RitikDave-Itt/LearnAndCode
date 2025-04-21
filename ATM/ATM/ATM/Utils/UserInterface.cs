using ATM.Exceptions;
using ATM.Models;
using ATM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Utils
{
    public static class UserInterface
    {
        public static string GetCardNumber()
        {
            Console.Write("Enter your Card Number: ");
            return Console.ReadLine();
        }

        public static decimal GetWithdrawalAmount()
        {
            while (true)
            {
                Console.Write("Enter amount to withdraw: ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal amount) && amount > 0)
                    return amount;

                Logger.LogError("Invalid amount. Please enter a positive number.");
            }
        }
        public static void TryValidatePin(Account account, ATMService service)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your PIN: ");
                string pin = Console.ReadLine();

                if (service.ValidatePin(account, pin))
                {
                    return;
                }

                attempts++;
                Logger.LogError($"Invalid PIN. Attempt {attempts}/{maxAttempts}");
            }

            throw new CardBlockedException("Wrong Pin Input Three Times your card is blocked for sometime");
        }
    }
}
