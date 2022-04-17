using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Operando
    {
        private double numero;


        /// <summary>
        /// Constructor de la clase operando
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Propiedades del campo numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// Recibe un numero binario formato strings llama a la validacion y realiza su cambio a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Valor invalido si el numero recibido no es vinario, el numero decimal si pudo realizar su tarea correctamente</returns>
        public string BinarioDecimal(string binario)
        {
            char[] arrayNumero = binario.ToCharArray();
            Array.Reverse(arrayNumero);
            int suma = 0;
            string resultado;

            if (!EsBinario(binario))
            {
                resultado = "Valor invalido";
            }
            else
            {
                for (int i = 0; i < arrayNumero.Length; i++)
                {
                    if (arrayNumero[i] == '1')
                    {
                        suma += (int)Math.Pow(2, i);
                    }
                }
            }
            resultado = suma.ToString();

            return resultado;
        }
        /// <summary>
        /// recibe un numero decimal como parametro y lo pasa a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor invalido si no pudo realizarlo, y el numero en binario si pudo realizarlo</returns>
        public string DecimalBinario(double numero)
        {
            string stringBinario = string.Empty;
            int modulo;
            int calcular;

            modulo = Math.Abs((int)numero);

            if (modulo == 0)
            {
                stringBinario = "0";
            }
            else
            {
                while (modulo > 0)
                {
                    calcular = modulo % 2;
                    modulo = modulo / 2;
                    stringBinario = calcular.ToString() + stringBinario;
                }

            }
            return stringBinario;
        }

        /// <summary>
        /// Recibe un string de numero como parametro, valida que sea un numero parseandolo y llama al pasaje de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor invalido si no pudo realizarlo, el numero binario si pudo realizarlo</returns>
        public string DecimalBinario(string numero)
        {
            double numeroBinario;
            bool resultado;
            resultado = double.TryParse(numero, out numeroBinario);
            if (resultado) 
            {
                return DecimalBinario(numeroBinario);
            }

            return "Valor invalido";

        }

        /// <summary>
        /// Recibe un string binario por parametro y valida que sea un binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Falso si no era binario, verdadero si es binario</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Constructor de la clase operando
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) 
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de la clase operando con un string como parametro
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) 
        {
            this.numero = ValidarOperando(strNumero);
        }

        /// <summary>
        /// Realiza la resta entre dos operandos
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la resta</returns>
        public static double operator - (Operando n1, Operando n2) 
        {
          
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza la suma entre dos parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma</returns>
        public static double operator + (Operando n1, Operando n2) 
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Realiza la multiplicacion entre dos parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la multiplicacion</returns>
        public static double operator * (Operando n1, Operando n2) 
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Realiza la division entre dos parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la division</returns>
        public static double operator / (Operando n1, Operando n2) 
        {
            if(n2.numero == 0) 
            {
                return double.MinValue;
            }
            else 
            {
                return n1.numero / n2.numero;
            }
        }
        /// <summary>
        /// Valida que el string recibido como parametro se trate de un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna 0 si no es valido, y el numero si es valido</returns>
        private static double ValidarOperando(string strNumero) 
        {
            bool resultado;
            double numero;
            resultado = double.TryParse(strNumero, out numero);
            if (!resultado) 
            {
                return 0;
            }

            return numero;
        }
    }
}
