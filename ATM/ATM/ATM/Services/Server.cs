using ATM.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    public class Server
    {
        public bool IsServerAvailable()
        {
            return new Random().Next(0, 10) > 1;
        }

        public void CheckServer()
        {
            if (!IsServerAvailable())
                throw new ServerConnectionException("Unable to connect to server. Please try again later.");
        }
    }
}
