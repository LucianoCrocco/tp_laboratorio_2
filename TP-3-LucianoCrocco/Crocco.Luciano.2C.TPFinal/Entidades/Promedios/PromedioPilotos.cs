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
        public string MaximoNroCompeticion()
        {
            int maximo = int.MinValue;
            foreach (Piloto item in lista)
            {
                if (item.NumeroCompeticion > maximo)
                {
                    maximo = item.NumeroCompeticion;
                }
            }
            return $"El numero de competicion mas grande elegido fue el {maximo}";
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

        public string MinimoNroCompeticion()
        {
            int minimo = int.MaxValue;
            foreach (Piloto item in lista)
            {
                if (item.NumeroCompeticion < minimo)
                {
                    minimo = item.NumeroCompeticion;
                }
            }
            return $"El numero de competicion mas chico elegido fue el {minimo}";
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
        public string PromedioEdad()
        {
            int acumulador = 0;
            float resultado = 0;
            foreach (Piloto item in lista)
            {
                acumulador += item.Edad;
            }
            resultado = (float) acumulador / this.lista.Count;
            return $"El promedio de edad entre los pilotos de la lista es de {resultado} años";
        }

        public string PromedioSexo()
        {
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
            return $"El {contadorMasc * 100 / this.lista.Count}% es de sexo masculino, con un total de {contadorMasc} ocurrencias. El {contadorFem * 100 / this.lista.Count}% es de sexo femenino, con un total de {contadorFem} ocurrencias. El {contadorOtro * 100 / this.lista.Count}% es de otro sexo, con un total de {contadorOtro} ocurrencias.";
        }

        public string PromedioNacionalidad()
        {
            int contadorNac = 0;
            int contadorOtro = 0;

            foreach (Piloto item in lista)
            {
                switch (item.CompetidorNacional)
                {
                    case true:
                        contadorNac++;
                        break;
                    default:
                        contadorOtro++;
                        break;
                }
            }
            return $"El {contadorNac * 100 / this.lista.Count}% son pilotos nacionales, con un total de {contadorNac} ocurrencias. El {contadorOtro * 100 / this.lista.Count}% son pilotos extranjeros, con un total de {contadorOtro} ocurrencias.";
        }

        public string PromedioNumeroElegido()
        {
            int acumulador = 0;
            float resultado = 0;
            foreach (Piloto item in lista)
            {
                acumulador += item.NumeroCompeticion;
            }
            resultado = (float)acumulador / this.lista.Count;
            return $"El numero de competicion promedio elegido por los pilotos es el numero {resultado}";
        }
        #endregion

        #endregion
    }
}
