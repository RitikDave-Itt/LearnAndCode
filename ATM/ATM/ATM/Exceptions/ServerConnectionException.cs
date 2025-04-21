using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Exceptions
{
    public class ServerConnectionException : Exception
    {
        public ServerConnectionException(string message) : base(message) { }
    }
}
