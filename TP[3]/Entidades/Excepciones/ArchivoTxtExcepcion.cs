using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ArchivoTxtExcepcion : Exception
    {
        public ArchivoTxtExcepcion(string message) : base(message)
        {
        }

        public ArchivoTxtExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
