using System;

namespace Entidades
{
    public class Calculadora
    {
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
