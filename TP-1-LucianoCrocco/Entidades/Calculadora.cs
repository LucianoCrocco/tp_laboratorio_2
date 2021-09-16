using System;

namespace Entidades
{
    public static class Calculadora
    {

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
        private static char ValidarOperador(char Operador)
        {
            switch (Operador)
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
