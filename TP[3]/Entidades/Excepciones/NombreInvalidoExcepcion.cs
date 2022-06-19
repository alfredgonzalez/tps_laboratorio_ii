using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NombreInvalidoExcepcion : Exception
    {
        public NombreInvalidoExcepcion(string message) : base(message)
        {
        }

        public NombreInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
