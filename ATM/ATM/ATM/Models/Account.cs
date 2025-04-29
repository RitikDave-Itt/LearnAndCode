using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
        public decimal DailyLimit { get; set; } = 20000;
        public decimal WithdrawnToday { get; set; } = 0;
        public bool IsBlocked { get; set; } = false;
        public int InvalidAttempts { get; set; } = 0;
    }
}
