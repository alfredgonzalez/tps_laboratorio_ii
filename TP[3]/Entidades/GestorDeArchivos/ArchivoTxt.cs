using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public class ArchivoTxt : GestorDeArchivos, IArchivos<string>
    {
        public ArchivoTxt() : base(ETipoArchivo.datosTXT)
        {
        }
        

        public string Escribir(string archivo, string datos) 
        {
            try
            {
                string ruta = $"{rutaBase}\\{archivo}{DateTime.Now.ToString("D")}.txt";
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.WriteLine(datos);
                }
                return "Ticket generado correctamente";
            }
            catch (Exception ex)
            {
                throw new ArchivoTxtExcepcion("Error al guardar los datos en un archivo de texto", ex);
            }

        }

    }
}
