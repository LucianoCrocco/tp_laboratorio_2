using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;

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
        public Escuderia() { }

        public Escuderia(string nombre, int cantidadPilotos)
            :this()
        {
            this.pilotosEnEscuderia = new List<Piloto>();
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
            set
            {
                this.pilotosEnEscuderia = value;
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
        public static bool operator ==(List<Escuderia> escuderias, Escuderia e1)
        {
            if (escuderias is not null && e1 is not null)
            {
                foreach (Escuderia item in escuderias)
                {
                    if (item.NombreEscuderia == e1.NombreEscuderia)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(List<Escuderia> escuderias, Escuderia e1)
        {
            return !(escuderias == e1);
        }

        public static List<Escuderia> operator +(List<Escuderia> escuderias, Escuderia e1)
        {
            if (escuderias is not null && e1 is not null)
            {
                if (escuderias == e1)
                {
                    throw new EscuderiaRepetidaException("La escuderia ya se encuentra en la lista");
                }
                
                escuderias.Add(e1);
            }

            return escuderias;
        }

        public static List<Escuderia> operator -(List<Escuderia> escuderias, Escuderia e1)
        {
            if (escuderias is not null && e1 is not null)
            {
                if (escuderias == e1)
                {
                    escuderias.Remove(e1);
                    return escuderias;
                }
                throw new EscuderiaNoEncontradaException("La escuderia no se encuentra en la lista");
            }
            return escuderias;
        }

        public static bool operator +(Escuderia escuderia, Piloto piloto)
        {
            if(escuderia is not null && piloto is not null)
            {
                foreach(Piloto item in escuderia.Pilotos)
                {
                    if(item == piloto)
                    {
                        throw new PilotoRepetidoException("El piloto ya se encuentra en la lista de la escuderia");
                    }
                }
                escuderia.Pilotos.Add(piloto);
            }

            return true;
        }

        public static bool operator -(Escuderia escuderia, Piloto piloto)
        {
            if (escuderia is not null && piloto is not null)
            {
                foreach (Piloto item in escuderia.Pilotos)
                {
                    if (item == piloto)
                    {
                        escuderia.Pilotos.Remove(item);
                        return true;
                    }
                }
                throw new PilotoNoEncontradoException("El piloto no se encuentra en la lista de la escuderia");
            }

            return true;
        }
        #endregion

        #region Metodos
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Escuderia {this.NombreEscuderia}, con asientos disponibles para {this.CantidadPilotos} pilotos.");
            return sb.ToString();
        }

        public static string MostrarTodosListaEscuderia(List<Escuderia> escuderia, string tipo)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\n\tLista de {tipo} cargados en el sistema");
            foreach (Escuderia item in escuderia)
            {
                sb.Append(item.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion
    }
}
