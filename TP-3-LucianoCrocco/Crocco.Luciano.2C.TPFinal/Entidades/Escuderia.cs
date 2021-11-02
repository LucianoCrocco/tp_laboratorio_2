using System;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Escuderia
    {
        #region Atributos
        protected string nombreEscuderia;
        protected int cantidadPilotos;
        protected ETipoCompeticion tipoCompeticionInscripto;
        protected List<Piloto> pilotos;
        #endregion

        #region Constructores

        private Escuderia()
        {
            this.pilotos = new List<Piloto>();
        }
        public Escuderia(string nombre, int cantidadPilotos, ETipoCompeticion tipoCompeticion)
            :this()
        {
            this.NombreEscuderia = nombre;
            this.CantidadPilotos = cantidadPilotos;
            this.TipoCompeticionInscripto = tipoCompeticion;
        }
        #endregion

        #region Propiedades
        public string NombreEscuderia
        {
            get
            {
                return this.nombreEscuderia;
            }
            set
            {
                this.nombreEscuderia = value;
            }
        }
        public int CantidadPilotos
        {
            get
            {
                return this.cantidadPilotos;
            }
            set
            {
                this.cantidadPilotos = value;
            }
        }
        public ETipoCompeticion TipoCompeticionInscripto
        {
            get {
                return this.tipoCompeticionInscripto;
            }
            set
            {
                this.tipoCompeticionInscripto = value;
            }
        }
        #endregion
    }
}
