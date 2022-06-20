using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T> where T : class
    {
        string Escribir(string nombreArchivo, T obj);
    }
}
