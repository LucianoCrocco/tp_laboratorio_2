using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        public Operando()
        {
            this.Numero = "0";
        }
        public Operando(double numero)
        {
            this.Numero = numero.ToString();
        }

        public Operando(string numero)
        {
            this.Numero = numero;
        }
        #endregion

        #region Setters y Getters
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }

        #endregion

        #region Metodos
        private static double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            if (double.TryParse(strNumero, out double auxNumero))
            {
                retorno = auxNumero;
            }
            return retorno;
        }

        private static bool EsBinario(string numero)
        {
            bool retorno = true;
            foreach (char caracter in numero)
            {
                if (caracter != '1' && caracter != '0')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            if (EsBinario(binario))
            {
                double auxNumero = 0;
                double cantidadDeCaracteres = binario.Length;

                foreach (char caracter in binario)
                {
                    cantidadDeCaracteres--;
                    if (caracter == '1')
                    {
                        auxNumero += (int)Math.Pow(2, cantidadDeCaracteres);
                    }
                }
                retorno = auxNumero.ToString();
            }
            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            string retorno = "";
            if(numero < 0)
            {
                numero = numero * -1;
            }

            int resultado = (int)numero;
            int aux;
            do
            {
                aux = resultado % 2;
                resultado /= 2;
                retorno = aux.ToString() + retorno;
            } while (resultado > 0);
            
            return retorno;
        }

        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            if(double.TryParse(numero, out double auxDecimal))
            {
                retorno = DecimalBinario(auxDecimal);
            }
            return retorno;
        }
        #endregion
    }
}
