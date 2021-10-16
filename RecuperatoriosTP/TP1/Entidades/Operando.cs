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
        /// <summary>
        /// Constructor por defecto de la clase operando, inicializa el numero en 0
        /// </summary>
        public Operando() : this(0)
        {
            /*this.Numero = "0";*/ //Error.. Se tiene que reutilizar el constructor. Es valido poner this(0) o simplemente el constructor vacio, es preferible el constructor vacio.
        }
        /// <summary>
        /// Constructor de un la clase Operando, recibe un numero de tipo double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            //this.Numero = numero.ToString(); -> Mas optimizado con el ejemplo debajo.
            this.numero = numero;
        }
        /// <summary>
        /// Constructor de un la clase Operando, recibe un numero de tipo string.
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Setters y Getters
        /// <summary>
        /// Setter del atributo numero, cambia el atributo de tipo string numero del objeto instanciado.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Recibe dos objetos del tipo Operando y realiza la suma del atributo numero de ambos.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Recibe dos objetos del tipo Operando y realiza la resta del atributo numero de ambos.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Recibe dos objetos del tipo Operando y realiza la multiplicacion del atributo numero de ambos.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Recibe dos objetos del tipo Operando y realiza la division del atributo numero de ambos.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Valida que el valor recibido a traves del parametro strNumero sea un numero valido, si no lo es retorna 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarOperando(string strNumero)
        {
            /* double retorno = 0; Error.. el tryParse va a inicializar ese out double "variable" en 0, no hace falta hacer esto. La variable sea true o false existe igual
             if (double.TryParse(strNumero, out double auxNumero))
             {
                 retorno = auxNumero;
             }
             return retorno;*/
            double.TryParse(strNumero, out double retorno);//Correcion
            return retorno;
        }

        /// <summary>
        /// Valida que el valor recibido a traves del parametro numero sea un numero binario (compuesto solo por 1 y 0), si lo es retorna true, caso contrario retorna false
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (char caracter in binario)
            {
                if (caracter != '1' && caracter != '0')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Recibe a traves del parametro string binario un numero binario, verifica que lo sea. Si lo es retorna el numero convertido a decimal, caso contrario retrona "Valor Invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Recibe a traves del parametro double numero un numero y lo convierte a binario. Retorna su valor absoluto en binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Recibe un parametro string numero, toma ese parametro y verifica que pueda convertirse a decimal para luego devolver su binario. Caso contrario devuelve "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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
