using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Piloto
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected ESexo sexo;
        protected int numeroCompeticion;
        protected bool competidorNacional;
        #endregion

        #region Constructores

        public Piloto() { }
        public Piloto (string nombre, string apellido, int edad, ESexo sexo, int numeroDeCompeticion, bool competidorNacional)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.NumeroCompeticion = numeroDeCompeticion;
            this.CompetidorNacional = competidorNacional;
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
                try 
                {
                    if (Piloto.ValidarNombre(value))
                    {
                        this.nombre = value;
                    }
                }
                catch (CaracteresInvalidoException ex)
                {
                    throw new CaracteresInvalidoException("El nombre ingresado es invalido", ex);
                } 
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                try
                {
                    if (Piloto.ValidarNombre(value))
                    {
                        this.apellido = value;
                    }
                }
                catch (CaracteresInvalidoException ex)
                {
                    throw new CaracteresInvalidoException("El apellido ingresado es invalido", ex);
                }
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public int NumeroCompeticion
        {
            get
            {
                return this.numeroCompeticion;
            }
            set
            {
                this.numeroCompeticion = value;
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public bool CompetidorNacional
        {
            get
            {
                return this.competidorNacional;
            }
            set
            {
                this.competidorNacional = value;
            }
        }

        #endregion

        #region Sobrecargas

        public static bool operator == (Piloto p1, Piloto p2)
        {
            if(p1 is not null && p2 is not null)
            {
                if(p1.NumeroCompeticion == p2.NumeroCompeticion)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Piloto p1, Piloto p2)
        {
            return !(p1 == p2);
        }

        public static List<Piloto> operator +(List<Piloto> pilotos, Piloto p1)
        {
            if(pilotos is not null && p1 is not null)
            {
                foreach(Piloto item in pilotos)
                {
                    if(item == p1)
                    {
                        throw new PilotoRepetidoException("El piloto ya se encuentra en la lista");
                    }
                }
                pilotos.Add(p1);
            }

            return pilotos;
        }

        public static List<Piloto> operator -(List<Piloto> pilotos, Piloto p1)
        {
            if (pilotos is not null && p1 is not null)
            {
                foreach (Piloto item in pilotos)
                {
                    if (item == p1)
                    {
                        pilotos.Remove(item);
                        return pilotos;
                    }
                }
                throw new PilotoNoEncontradoException("El piloto no se encuentra en la lista");
            }

            return pilotos;
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido}, {this.Edad} años, sexo: {this.Sexo}, numero de competicion: {this.NumeroCompeticion}, ¿es argentino?: {(this.CompetidorNacional ? "Si":"No")}");
            return sb.ToString();
        }

        public static bool ValidarNombre(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new CaracteresInvalidoException("Los cadena de caracteres ingresados se encuentra vacia");
            } 
            else
            {
                foreach(char caracter in value)
                {
                    if((caracter < 65 || caracter > 90) && (caracter < 97 || caracter > 122))
                    {
                        throw new CaracteresInvalidoException("Los cadena de caracteres ingresados contiene caracteres invalidos");
                    }
                }
            }
            return true;
        }

        public static string MostrarTodosListaPilotos(List<Piloto> pilotos)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\tLista de pilotos cargados en el sistema");
            foreach(Piloto item in pilotos)
            {
                sb.Append(item.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion
    }
}
