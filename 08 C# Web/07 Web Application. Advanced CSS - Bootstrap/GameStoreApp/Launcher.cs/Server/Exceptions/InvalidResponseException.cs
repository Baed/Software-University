using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Exceptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException(string message)
            : base(message)
        {
        }
    }
}