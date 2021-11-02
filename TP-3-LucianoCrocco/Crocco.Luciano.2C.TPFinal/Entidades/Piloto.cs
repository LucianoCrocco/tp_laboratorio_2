using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Piloto (string nombre, string apellido, int edad, ESexo sexo, int numeroDeCompeticion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.NumeroCompeticion = numeroDeCompeticion;
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

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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
            set
            {
                this.competidorNacional = value;
            }
            get
            {
                return this.competidorNacional;
            }
        }
        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Piloto p1, Piloto p2)
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



        #endregion

    }
}
