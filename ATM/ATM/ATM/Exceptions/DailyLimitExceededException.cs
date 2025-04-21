using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM.Exceptions
{
    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message) { }
    }
}

