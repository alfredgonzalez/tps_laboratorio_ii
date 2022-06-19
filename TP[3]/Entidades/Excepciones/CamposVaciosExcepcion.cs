using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposVaciosExcepcion : Exception
    {
        public CamposVaciosExcepcion(string message) : base(message)
        {
        }

        public CamposVaciosExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
