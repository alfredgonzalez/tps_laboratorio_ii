using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ProductoNoExisteExcepcion : Exception
    {
        public ProductoNoExisteExcepcion(string message) : base(message)
        {
        }

        public ProductoNoExisteExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
