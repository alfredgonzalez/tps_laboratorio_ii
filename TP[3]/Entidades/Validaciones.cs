using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public class Validaciones
    {
        public static bool ValidarCliente(string nombre, string apellido, string dni, string celular)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido)
                || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(celular))
            {
                throw new CamposVaciosExcepcion("Error! faltan datos de cliente");

            }
            return true;
        }
        public static bool ValidarNombre(string nombre)
        {
            if (nombre.Length < 2)
            {
                throw new NombreInvalidoExcepcion("Error, el nombre no puede contener menos de 2 letras");
            }
            else if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$")) 
            {
                throw new NombreInvalidoExcepcion("El nombre tiene que contener solo letras.");
            }
            return true;
        }
        public static bool ValidarApellido(string apellido)
        {
            if (apellido.Length < 2)
            {
                throw new ApellidoInvalidoExcepcion("Error, el apellido no puede tener menos de 2 letras");
            }
            else if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$")) 
            {
                throw new ApellidoInvalidoExcepcion("Error, el apellido tiene que contener solo letras.");
            }
            return true;
        }
        public static bool ValidarDni(string dni)
        {
            if (!Regex.IsMatch(dni, @"^[0-9]+$"))
            {
                throw new DniInvalidoExcepcion("Error, el dni tiene que contener solo numeros");
            }
            else if (dni.Length <= 0 || dni.Length > 10)
            {
                throw new DniInvalidoExcepcion("Error, el dni debe tener 8 digitos");
            }
            return true;
        }
        public static bool ValidarNumeroCelular(string celular)
        {
            if (!Regex.IsMatch(celular, @"^[0-9]+$"))
            {
                throw new CelularInvalidoExcepcion("Error, el celular tiene que contener solo numeros");
            }
            else if (celular.Length != 10)
            {
                throw new CelularInvalidoExcepcion("Error, numero de celular invalido");
            }
            return true;
        }
        public static bool ValidarCamposVacios(string datos) 
        {
            if (string.IsNullOrEmpty(datos)) 
            {
                throw new CamposVaciosExcepcion("Error, rellene todos los campos para continuar");
            }
            else if (string.IsNullOrWhiteSpace(datos)) 
            {
                throw new CamposVaciosExcepcion("Error, rellene todos los campos sin espacios vacios");
            }
            return true;
        }
        public static bool ValidarSoloNumeros(string numeros) 
        {
            if (!double.TryParse(numeros, out double numerosAux)) 
            {
                throw new PrecioNoValidoExcepcion("Error, el precio solo puede contener numeros");
            }
            else if(numerosAux <=0 || numerosAux > 990000)
            {
                throw new PrecioNoValidoExcepcion("Error, el precio colocado no es valido");
            }
            return true;
        }
        public static bool ValidarSoloLetras(string letras) 
        {
            if(!Regex.IsMatch(letras, @"^[a-zA-Z]+$")) 
            {
                throw new SoloLetrasExcepcion("Error, el campo debe contener solo letras");
            }
            return true;
        }
    }
}
