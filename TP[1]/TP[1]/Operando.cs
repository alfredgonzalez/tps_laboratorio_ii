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


        public Operando()
        {
            this.numero = 0;
        }
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

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

        public Operando(double numero) 
        {
            this.numero = numero;
        }

        public Operando(string strNumero) 
        {
            this.numero = ValidarOperando(strNumero);
        }


        public static double operator - (Operando n1, Operando n2) 
        {
          
            return n1.numero - n2.numero;
        }

        public static double operator + (Operando n1, Operando n2) 
        {
            return n1.numero + n2.numero;
        }

        public static double operator * (Operando n1, Operando n2) 
        {
            return n1.numero * n2.numero;
        }

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
