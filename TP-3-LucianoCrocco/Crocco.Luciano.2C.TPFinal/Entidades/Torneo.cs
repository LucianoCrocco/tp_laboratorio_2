using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Escuderia
    {
        #region Atributos
        protected string nombre;
        protected int cantidadDePilotos;
        protected ETipoCompeticion tipoCompeticion;
        List<T> escuderiasEnCompetencia;
        #endregion

        #region Constructores
        public Torneo(string nombre, int cantidadDePilotosPosibles, ETipoCompeticion tipoCompetencia)
        {
            this.Nombre = nombre;
            this.CantidadPilotos = cantidadDePilotosPosibles;
            this.TipoCompeticion = tipoCompetencia;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int CantidadPilotos
        {
            get
            {
                return this.cantidadDePilotos;
            }
            set
            {
                this.cantidadDePilotos = value;
            }
        }
        public ETipoCompeticion TipoCompeticion
        {
            get
            {
                return this.tipoCompeticion;
            }
            set
            {
                this.tipoCompeticion = value;
            }
        }
        #endregion

    }
}
