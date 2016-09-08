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

        public static explicit operator string(Paleta p)
        {
            return Paleta.Mostrar(p);
        }

        private static string Mostrar(Paleta p)
        {
            string ret = "CantidadMaximaDeColores : " + p._cantidadMaximaColores + "\n";
            for (int i = 0; i < p.Ocupados(); i++)
            {
                ret += p._colores[i];
            }
            return ret;
        }
        
        public static bool operator ==(Paleta p, Tempera t)
        {
            foreach (Tempera temp in p._colores)
            {
                if (temp == t) return true;
            }
            return false;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }


        /*public static implicit operator String(Paleta p)
        {
            return Paleta.Mostrar(p);
        }*/


        public static Paleta operator +(Paleta p, Tempera t)
        {            
            if ( p != t)
            {
                int ocupados = p.Ocupados();
                if(ocupados < p._cantidadMaximaColores)
                {
                    p._colores[ocupados] = t;
                }
            }
            return p;
        }

        /*public static Paleta operator +(Paleta p1, Paleta p2)
        {
            HACER
        }*/

        /*public static Paleta operator -(Paleta p1, Tempera p2)
        {
            HACER: le saco la tempera a la paleta.
        }*/



        private int Ocupados()
        {
            int i = 0;
            for ( i = 0; i < this._cantidadMaximaColores && !this._colores[i].Equals(null); i++);
            return i < this._cantidadMaximaColores ? i : -1;
        }
        
    }
}
