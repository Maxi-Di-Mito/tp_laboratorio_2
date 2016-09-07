using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Paleta
    {
        private Tempera[] _colores;
        private sbyte _cantidadMaximaColores;

        private Paleta() : this(4) { }        

        private Paleta(sbyte cant)
        {
            this._cantidadMaximaColores = cant;
            this._colores = new Tempera[cant];
        }

        public static implicit operator Paleta(sbyte cant)
        {
            return new Paleta(cant);
        }

        private static string Mostrar(Paleta p)
        {
            string ret = "CantidadMaximaDeColores : " + p._cantidadMaximaColores + "\n";
            foreach (Tempera t in p._colores)
            {
                ret += t;
            }
            return ret;
        }        

        public static implicit operator String(Paleta p)
        {
            return Paleta.Mostrar(p);
        }


        /*public static void operator +(Paleta p, Tempera t)
        {
            
        }*/



        
    }
}
