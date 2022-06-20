using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class DniInvalidoExcepcion : Exception
    {
        public DniInvalidoExcepcion(string message) : base(message)
        {
        }

        public DniInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
