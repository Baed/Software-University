using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Exceptions
{
    public class BadRequestException : Exception
    {
        private const string InvalidRequestMessage = "Request is not valid.";

        public static object ThrowFromInvalidRequest()
            => throw new BadRequestException(InvalidRequestMessage);

        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}