using System;

namespace LocationFinder.Utilities.Exceptions
{
    public class NullResponseException : Exception
    {
        public NullResponseException()
            : base("The response from the API was null.")
        {
        }

        public NullResponseException(string message)
            : base(message)
        {
        }

        public NullResponseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        
    }
}
