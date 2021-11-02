using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EscuderiaSTC2000 : Escuderia
    {
        #region Atributos
        protected EMarcaVehiculoSTC2000 marcaVehiculo;
        #endregion

        #region Constructores
        public EscuderiaSTC2000(string nombre, int cantidadPilotos, EMarcaVehiculoSTC2000 fabricanteVehiculo)
            : base(nombre, cantidadPilotos, ETipoCompeticion.STC2000)
        {
            this.marcaVehiculo = fabricanteVehiculo;
        }
        #endregion

        #region Propiedades
        public EMarcaVehiculoSTC2000 marcaVehiculoSTC2000
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
    }
}
