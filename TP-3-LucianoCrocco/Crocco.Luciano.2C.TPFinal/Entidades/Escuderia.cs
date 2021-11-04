using System;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Escuderia
    {
        #region Atributos
        protected string nombreEscuderia;
        protected int cantidadPilotos;
        protected List<Piloto> pilotosEnEscuderia;
        #endregion

        #region Constructores

        private Escuderia()
        {
            this.pilotosEnEscuderia = new List<Piloto>();
        }
        public Escuderia(string nombre, int cantidadPilotos)
            :this()
        {
            this.NombreEscuderia = nombre;
            this.CantidadPilotos = cantidadPilotos;
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

        public List<Piloto> Pilotos
        {
            get
            {
                return this.pilotosEnEscuderia;
            }
        }
        #endregion

        public static bool operator ==(Escuderia e1, Escuderia e2)
        {
            if(e1 is not null && e2 is not null)
            {
                if(e1.NombreEscuderia == e2.NombreEscuderia)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Escuderia e1, Escuderia e2)
        {
            return !(e1 == e2);
        }

    }
}
