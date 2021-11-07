using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class PromedioEscuderias<T>
        where T : Escuderia
    {
        List<Escuderia> lista;
        public PromedioEscuderias(List<Escuderia> listaEscuderias)
        {
            this.lista = listaEscuderias;
        }
        public string MaximoAsientosPiloto()
        {
            int maximo = int.MinValue;
            foreach (T item in lista)
            {
                if (item.CantidadPilotos > maximo)
                {
                    maximo = item.CantidadPilotos;
                }
            }
            return $"La edad maxima registrada en la lista de pilotos es de {maximo} años";
        }

    }
}
