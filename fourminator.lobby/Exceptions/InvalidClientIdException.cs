using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourminator.Lobby.Exceptions
{
    internal class InvalidClientIdException : Exception
    {
        public InvalidClientIdException(Exception innerException) : base(message: "An invalid or non-existend client id was provided!", innerException: innerException) {
        
        }
    }
}
