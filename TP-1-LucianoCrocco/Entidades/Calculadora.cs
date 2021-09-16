using System;

namespace Entidades
{
    public static class Calculadora
    {

        public static double Operar(Operando num1, Operando num2, char operador)
        {

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
