using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ApellidoInvalidoExcepcion : Exception
    {
        public ApellidoInvalidoExcepcion(string message) : base(message)
        {
        }

        public ApellidoInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
