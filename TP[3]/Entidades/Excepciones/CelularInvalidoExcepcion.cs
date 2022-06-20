using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CelularInvalidoExcepcion : Exception
    {
        public CelularInvalidoExcepcion(string message) : base(message)
        {
        }

        public CelularInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
