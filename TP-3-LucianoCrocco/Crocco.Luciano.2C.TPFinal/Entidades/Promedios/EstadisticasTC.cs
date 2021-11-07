using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadisticasTC : EstadisticasEscuderias
    {
        public EstadisticasTC(List<Escuderia> listaEscuderias) : base(listaEscuderias)
        {
        }

        #region Maximo
        public string AutosMasUtilizado()
        {
            string retorno = String.Empty;
            int contadorFord = 0;
            int contadorChevrolet = 0;
            int contadorTorino = 0;
            int contadorDodge = 0;
            int contadorToyota = 0;

            foreach (EscuderiaTC item in Lista)
            {
                switch (item.MarcaVehiculoTC)
                {
                    case EMarcaVehiculoTC.Ford:
                        contadorFord++;
                        break;
                    case EMarcaVehiculoTC.Chevrolet:
                        contadorChevrolet++;
                        break;
                    case EMarcaVehiculoTC.Torino:
                        contadorTorino++;
                        break;
                    case EMarcaVehiculoTC.Dodge:
                        contadorDodge++;
                        break;
                    default:
                        contadorToyota++;
                        break;
                }
            }

            if (contadorFord >= contadorChevrolet && contadorFord >= contadorTorino && contadorFord >= contadorDodge && contadorFord >= contadorToyota)
            {
                retorno = $"La marca predominante entre las escuderias es Ford con un total de {contadorFord} coincidencias.";
            }
            else if (contadorChevrolet > contadorFord && contadorChevrolet > contadorTorino && contadorChevrolet > contadorDodge && contadorChevrolet > contadorToyota)
            {
                retorno = $"La marca predominante entre las escuderias es Chevrolet con un total de {contadorChevrolet} coincidencias.";
            }
            else if (contadorTorino > contadorFord && contadorTorino > contadorChevrolet && contadorTorino > contadorDodge && contadorTorino > contadorToyota)
            {
                retorno = $"La marca predominante entre las escuderias es Torino con un total de {contadorTorino} coincidencias.";
            }
            else if (contadorDodge > contadorFord && contadorDodge > contadorChevrolet && contadorDodge > contadorTorino && contadorDodge > contadorToyota)
            {
                retorno = $"La marca predominante entre las escuderias es Dodge con un total de {contadorDodge} coincidencias.";
            }
            else
            {
                retorno = $"La marca predominante entre las escuderias es Toyota con un total de {contadorToyota} coincidencias.";
            }
            return retorno;
        }
        #endregion

        #region Minimo
        public string AutosMenosUtilizado()
        {
            string retorno = String.Empty;
            int contadorFord = 0;
            int contadorChevrolet = 0;
            int contadorTorino = 0;
            int contadorDodge = 0;
            int contadorToyota = 0;

            foreach (EscuderiaTC item in Lista)
            {
                switch (item.MarcaVehiculoTC)
                {
                    case EMarcaVehiculoTC.Ford:
                        contadorFord++;
                        break;
                    case EMarcaVehiculoTC.Chevrolet:
                        contadorChevrolet++;
                        break;
                    case EMarcaVehiculoTC.Torino:
                        contadorTorino++;
                        break;
                    case EMarcaVehiculoTC.Dodge:
                        contadorDodge++;
                        break;
                    default:
                        contadorToyota++;
                        break;
                }
            }

            if (contadorFord <= contadorChevrolet && contadorFord <= contadorTorino && contadorFord <= contadorDodge && contadorFord <= contadorToyota)
            {
                retorno = $"La marca menos predominante entre las escuderias es Ford con un total de {contadorFord} coincidencias.";
            }
            else if (contadorChevrolet < contadorFord && contadorChevrolet < contadorTorino && contadorChevrolet < contadorDodge && contadorChevrolet < contadorToyota)
            {
                retorno = $"La marca menos predominante entre las escuderias es Chevrolet con un total de {contadorChevrolet} coincidencias.";
            }
            else if (contadorTorino < contadorFord && contadorTorino < contadorChevrolet && contadorTorino < contadorDodge && contadorTorino < contadorToyota)
            {
                retorno = $"La marca menos predominante entre las escuderias es Torino con un total de {contadorTorino} coincidencias.";
            }
            else if (contadorDodge < contadorFord && contadorDodge < contadorChevrolet && contadorDodge < contadorTorino && contadorDodge < contadorToyota)
            {
                retorno = $"La marca menos predominante entre las escuderias es Dodge con un total de {contadorDodge} coincidencias.";
            }
            else
            {
                retorno = $"La marca menos predominante entre las escuderias es Toyota con un total de {contadorToyota} coincidencias.";
            }
            return retorno;
        }
        #endregion

        #region Promedio
        public string PromedioAutosUtilizados()
        {
            StringBuilder sb = new StringBuilder();
            int contadorFord = 0;
            int contadorChevrolet = 0;
            int contadorTorino = 0;
            int contadorDodge = 0;
            int contadorToyota = 0;

            foreach (EscuderiaTC item in Lista)
            {
                switch (item.MarcaVehiculoTC)
                {
                    case EMarcaVehiculoTC.Ford:
                        contadorFord++;
                        break;
                    case EMarcaVehiculoTC.Chevrolet:
                        contadorChevrolet++;
                        break;
                    case EMarcaVehiculoTC.Torino:
                        contadorTorino++;
                        break;
                    case EMarcaVehiculoTC.Dodge:
                        contadorDodge++;
                        break;
                    default:
                        contadorToyota++;
                        break;
                }
            }
            sb.AppendLine($"El {contadorFord * 100 / this.Lista.Count}% utiliza Ford, con un total de {contadorFord} ocurrencias.");
            sb.AppendLine($"El {contadorChevrolet * 100 / this.Lista.Count}% utiliza Chevrolet, con un total de {contadorChevrolet} ocurrencias.");
            sb.AppendLine($"El {contadorTorino * 100 / this.Lista.Count}% utiliza Torino, con un total de {contadorTorino} ocurrencias.");
            sb.AppendLine($"El {contadorDodge * 100 / this.Lista.Count}% utiliza Dodge, con un total de {contadorDodge} ocurrencias.");
            sb.AppendLine($"El {contadorToyota * 100 / this.Lista.Count}% utiliza Toyota, con un total de {contadorToyota} ocurrencias.");
            return sb.ToString();
        }
        #endregion
    }
}
