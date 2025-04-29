using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Exceptions
{
    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string cardNumber)
            : base($"Account with card number {cardNumber} was not found.")
        {
        }
    }
}
