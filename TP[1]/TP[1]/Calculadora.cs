using System;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Se encarga de realizar la operacion con los parametros recibidos
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador) 
        {
            double operacion;

            operador = ValidarOperador(operador);
            switch (operador) 
            {
                case '+':
                    operacion = num1 + num2;
                    break;
                case '-':
                    operacion = num1 - num2;
                    break;
                case '*':
                    operacion = num1 * num2;
                    break;
                case '/':
                    operacion = num1 / num2;
                    break;
                default:
                    
                    operacion = num1 + num2;
                    break;

            }
            return operacion;
        }

        /// <summary>
        /// valida el operador recibido como parametro
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el operador, o retorna + en caso de no haber ninguno operador </returns>
        private static char ValidarOperador(char operador) 
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/') 
            {
                return operador;
            }

            return '+';
        }
    }
}
