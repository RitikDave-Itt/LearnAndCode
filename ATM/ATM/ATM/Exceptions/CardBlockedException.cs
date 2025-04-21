using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Exceptions
{
    public  class CardBlockedException:Exception
    {
        public CardBlockedException(string message) : base(message) { }
    }
}
