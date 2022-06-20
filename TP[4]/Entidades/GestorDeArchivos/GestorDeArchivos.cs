using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class GestorDeArchivos
    {
        public enum ETipoArchivo { datosTXT, datosXML };
        protected string rutaBase;
        protected ETipoArchivo tipoArchivo;

        protected GestorDeArchivos(ETipoArchivo tipoArchivo)
        {
            string carpeta = "Datos";
            DirectoryInfo ruta = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{carpeta}\\{tipoArchivo}\\");
            this.rutaBase = ruta.FullName;
            this.tipoArchivo = tipoArchivo;
        }
    }
}
