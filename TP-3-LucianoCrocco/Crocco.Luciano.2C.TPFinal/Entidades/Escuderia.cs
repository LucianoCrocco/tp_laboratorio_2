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

        #region Sobrecarga operadores
        public static bool operator ==(Escuderia escuderia, Piloto piloto)
        {
            if(escuderia is not null && piloto is not null)
            {
                foreach(Piloto item in escuderia.Pilotos)
                {
                    if(item == piloto)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Escuderia escuderia, Piloto piloto)
        {
            return !(escuderia == piloto);
        }

        public override bool Equals(object obj)
        {
            Escuderia escuderia = obj as Escuderia;

            return this.NombreEscuderia == escuderia.NombreEscuderia;
        }
        #endregion
    }
}
