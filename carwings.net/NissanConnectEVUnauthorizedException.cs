using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace carwings.net
{
    public class NissanConnectEVUnauthorizedException : Exception
    {
        public NissanConnectEVUnauthorizedException() : base()
        {
        }

        public NissanConnectEVUnauthorizedException(String message) : base(message)
        {
        }

        public NissanConnectEVUnauthorizedException(String message, Exception innerException) : base(message, innerException)
        {
        }

        public NissanConnectEVUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
