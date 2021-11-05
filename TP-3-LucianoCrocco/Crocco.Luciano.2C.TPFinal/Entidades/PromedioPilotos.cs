using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PromedioPilotos
    {
        List<Piloto> lista;
        public PromedioPilotos(List<Piloto> listaPilotos)
        {
            this.lista = listaPilotos;
        }

        #region Metodos

            #region Maximos
        public string MaximoEdad()
        {
            int maximo = int.MinValue;
            foreach (Piloto item in lista)
            {
                if (item.Edad > maximo)
                {
                    maximo = item.Edad;
                }
            }
            return $"La edad maxima registrada en la lista de pilotos es de {maximo} años";
        }
        public string MaximoSexo()
        {
            string retorno = String.Empty;
            int contadorMasc = 0;
            int contadorFem = 0;
            int contadorOtro = 0;

            foreach (Piloto item in lista)
            {
                switch (item.Sexo)
                {
                    case ESexo.Masculino:
                        contadorMasc++;
                        break;
                    case ESexo.Femenino:
                        contadorFem++;
                        break;
                    default:
                        contadorOtro++;
                        break;
                }
            }

            if (contadorMasc >= contadorFem && contadorMasc >= contadorOtro)
            {
                retorno = $"El genero predominante entre los pilotos es el masculino con un total de {contadorMasc} coincidencias";
            }
            else if (contadorFem > contadorMasc && contadorFem > contadorOtro)
            {
                retorno = $"El genero predominante entre los pilotos es el femenino con un total de {contadorFem} coincidencias";
            }
            else
            {
                retorno = $"El genero predominante entre los pilotos es otro con un total de {contadorOtro} coincidencias";
            }
            return retorno;
        }

        public string MaximoNacionalidad()
        {
            string retorno = String.Empty;
            int contadorNac = 0;
            int contadorNoNac = 0;


            foreach (Piloto item in lista)
            {
                switch (item.CompetidorNacional)
                {
                    case true:
                        contadorNac++;
                        break;
                    default:
                        contadorNoNac++;
                        break;
                }

                if (contadorNac >= contadorNoNac)
                {
                    retorno = $"La mayor parte de los pilotos son pilotos nacionales con un total de {contadorNac} coincidencias";
                }
                else
                {
                    retorno = $"La mayor parte de los pilotos son pilotos internacionales con un total de {contadorNoNac} coincidencias";
                }
            }
            return retorno;
        }
            #endregion

            #region Minimos


        public string MinimoEdad()
        {
            int minimo = int.MaxValue;
            foreach (Piloto item in lista)
            {
                if (item.Edad < minimo)
                {
                    minimo = item.Edad;
                }
            }
            return $"La edad minima registrada en la lista de pilotos es de {minimo} años";
        }

        

        public string MinimoSexo()
        {
            string retorno = String.Empty;
            int contadorMasc = 0;
            int contadorFem = 0;
            int contadorOtro = 0;

            foreach (Piloto item in lista)
            {
                switch (item.Sexo)
                {
                    case ESexo.Masculino:
                        contadorMasc++;
                        break;
                    case ESexo.Femenino:
                        contadorFem++;
                        break;
                    default:
                        contadorOtro++;
                        break;
                }
            }

            if (contadorMasc <= contadorFem && contadorMasc <= contadorOtro)
            {
                retorno = $"El genero menos predominante entre los pilotos es el masculino con un total de {contadorMasc} coincidencias";
            }
            else if (contadorFem < contadorMasc && contadorFem <= contadorOtro)
            {
                retorno = $"El genero menos predominante entre los pilotos es el femenino con un total de {contadorFem} coincidencias";
            }
            else
            {
                retorno = $"El genero menos predominante entre los pilotos es otro con un total de {contadorOtro} coincidencias";
            }
            return retorno;
        }



        public string MinimoNacionalidad()
        {
            string retorno = String.Empty;
            int contadorNac = 0;
            int contadorNoNac = 0;


            foreach (Piloto item in lista)
            {
                switch (item.CompetidorNacional)
                {
                    case true:
                        contadorNac++;
                        break;
                    default:
                        contadorNoNac++;
                        break;
                }

                if (contadorNac <= contadorNoNac)
                {
                    retorno = $"La menor parte de los pilotos son pilotos nacionales con un total de {contadorNac} coincidencias";
                }
                else
                {
                    retorno = $"La menor parte de los pilotos son pilotos internacionales con un total de {contadorNoNac} coincidencias";
                }
            }
            return retorno;
        }
        #endregion

            #region Promedio
            #endregion
        #endregion
    }
}
