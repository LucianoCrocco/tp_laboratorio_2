using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza operaciones aritmeticas entre el Operando num1 y el Operando num2, dependiendo del operador recibido.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char simboloCuenta = ValidarOperador(operador);
            double resultado = 0;
            switch (simboloCuenta)
            {
                case '/':
                    resultado = num1 / num2;
                    break;
                case '-':
                    resultado =  num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '+':
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Valida que el operador recibido sea valido, si este es no es '/', '*' y '-' devolvera por default el operador '+'.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '/':
                    return '/';
                case '-':
                    return '-';
                case '*':
                    return '*';
                default:
                    return '+';
            }
        }

    }
}
