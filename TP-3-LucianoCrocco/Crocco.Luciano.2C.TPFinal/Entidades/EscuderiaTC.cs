using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EscuderiaTC : Escuderia
    {
        #region Atributos
        protected EMarcaVehiculoTC marcaVehiculo;
        #endregion

        #region Constructores

        public EscuderiaTC() { }

        public EscuderiaTC(string nombre, int cantidadPilotos, EMarcaVehiculoTC fabricanteVehiculo)
            :base(nombre, cantidadPilotos)
        {
            this.marcaVehiculo = fabricanteVehiculo;
        }
        #endregion

        #region Propiedades
        public EMarcaVehiculoTC MarcaVehiculoTC
        {
            get
            {
                return this.marcaVehiculo;
            }
            set
            {
                this.marcaVehiculo = value;
            }
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($" La marca elegida por la escuderia es {this.MarcaVehiculoTC}");
            return sb.ToString();
        }
        #endregion
    }
}
