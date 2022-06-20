using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class PrecioNoValidoExcepcion : Exception
    {
        public PrecioNoValidoExcepcion(string message) : base(message)
        {
        }

        public PrecioNoValidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
