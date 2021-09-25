using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Enumerados
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion

        #region Atributos
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion

        #region Constructores
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region Getters y Setters
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get; }
        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"CHASIS: {p.chasis}\r\n");
            sb.Append($"MARCA : {p.marca.ToString()}\r\n");
            sb.Append($"COLOR : {p.color.ToString()}\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        public override bool Equals(object obj)
        {
            Vehiculo vehiculo = obj as Vehiculo;

            return !(vehiculo is null) && this == vehiculo;
        }

        public override int GetHashCode()
        {
            return chasis.GetHashCode();
        }
        #endregion
    }
}
