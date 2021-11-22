using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiExtension
    {
        public static int ContadorDeLetras(this String str)
        {
            int contador = 0;
            foreach(char caracter in str)
            {
                contador++;
            }
            return contador;
        }
    }
}
