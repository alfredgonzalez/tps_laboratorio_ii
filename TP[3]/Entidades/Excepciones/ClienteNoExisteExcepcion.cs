using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteNoExisteExcepcion : Exception
    {
        public ClienteNoExisteExcepcion(string message) : base(message)
        {
        }

        public ClienteNoExisteExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
