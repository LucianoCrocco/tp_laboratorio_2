using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class PromedioEscuderias
    {
        List<Escuderia> lista;
        public PromedioEscuderias(List<Escuderia> listaEscuderias)
        {
            this.Lista = listaEscuderias;
        }

        public List<Escuderia> Lista
        {
            set
            {
                this.lista = value;
            }
            get
            {
                return this.lista;
            }
        }

        #region Metodos
        public string MaximoAsientosDisponiblesPiloto()
        {
            int maximo = int.MinValue;
            foreach (Escuderia item in lista)
            {
                if (item.CantidadPilotos > maximo)
                {
                    maximo = item.CantidadPilotos;
                }
            }
            return $"El maximo de asientos disponibles registrado en la lista de escuderias es de {maximo} asientos.";
        }

        public string MinimoAsientosDisponiblesPiloto()
        {
            int minimo = int.MaxValue;
            foreach (Escuderia item in lista)
            {
                if (item.CantidadPilotos < minimo)
                {
                    minimo = item.CantidadPilotos;
                }
            }
            return $"El minimo de asientos disponibles registrado en la lista de escuderias es de {minimo} asientos.";
        }

        public string PromedioAsientosDisponiblesPiloto()
        {
            float promedio = 0;
            int acumulador = 0;
            foreach (Escuderia item in lista)
            {
                acumulador += item.CantidadPilotos;
            }
            promedio = (float) acumulador /  this.lista.Count;
            return $"El promedio de asientos disponibles registrado en la lista de escuderias es de {promedio} asientos.";
        }

        public string MaximoAsientosOcupadosPiloto()
        {
            int maximo = int.MinValue;
            foreach (Escuderia item in lista)
            {
                if (item.Pilotos.Count > maximo)
                {
                    maximo = item.Pilotos.Count;
                }
            }
            return $"El maximo de asientos ocupados registrado en la lista de escuderias es de {maximo} asientos.";
        }

        public string MinimoAsientosOcupadosPiloto()
        {
            int minimo = int.MaxValue;
            foreach (Escuderia item in lista)
            {
                if (item.Pilotos.Count < minimo)
                {
                    minimo = item.CantidadPilotos;
                }
            }
            return $"El minimo de asientos ocupados registrado en la lista de escuderias es de {minimo} asientos.";
        }

        public string PromedioAsientosOcupadosPiloto()
        {
            float promedio = 0;
            int acumuladorOcupado = 0;
            int acumuladorDisponible = 0;
            foreach (Escuderia item in lista)
            {
                acumuladorOcupado += item.Pilotos.Count;
                acumuladorDisponible += item.CantidadPilotos;
            }
            promedio = (float)acumuladorOcupado / acumuladorDisponible;
            return $"El promedio de asientos ocupados registrado en la lista de escuderias es de {promedio} asientos.";
        }

        #endregion
    }
}
