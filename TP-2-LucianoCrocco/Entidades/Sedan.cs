using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Atributos
        public enum ETipo { CuatroPuertas, CincoPuertas }

        private ETipo tipo;
        #endregion

        #region Constructores
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas. Constructor sin especificar el tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        /// <summary>
        /// Constructor que especifica el tipo de vehiculo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            :base(chasis, marca, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de la Sedan.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append(base.Mostrar());
            sb.AppendLine("\nTIPO : " + this.tipo);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

    }
}
