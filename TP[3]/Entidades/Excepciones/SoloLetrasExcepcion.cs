﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class SoloLetrasExcepcion : Exception
    {
        public SoloLetrasExcepcion(string message) : base(message)
        {
        }

        public SoloLetrasExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
