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
            else
            {
                for (int i = 0; i < p.Ocupados(); i++)
                {
                    if (p._colores[i] == t)
                    {
                        p._colores[i] += t;
                        break;
                    }
                }
            }

            return p;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {            
            Paleta paletaAuxiliar = new Paleta((sbyte)(p1._cantidadMaximaColores + p2._cantidadMaximaColores));

            for (int i = 0; i < p1.Ocupados(); i++)
            {
                paletaAuxiliar += p1._colores[i];
            }
            for (int i = 0; i < p2.Ocupados(); i++)
            {
                paletaAuxiliar += p2._colores[i];
            }

            Paleta laPostaPaleta = new Paleta((sbyte)paletaAuxiliar.Ocupados());

            for (int i = 0; i < paletaAuxiliar.Ocupados(); i++)
            {
                laPostaPaleta += paletaAuxiliar._colores[i];
            }            
            return laPostaPaleta;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int index = p.WhereIsThisTempera(t);
            if (index != -1)
            {
                p._colores[index] = null;
                p.Compact();
            }
            return p;
        }


        private void Compact()
        {
            for (int i = 0; i < this._cantidadMaximaColores-1; i++)
            {
                if (Object.Equals(this._colores[i], null))
                {
                    this._colores[i] = this._colores[i + 1];
                }
            }
        }


        private int WhereIsThisTempera(Tempera t)
        {
            int i = 0;
            for ( i = 0; i < this.Ocupados(); i++)
            {
                if (this._colores[i] == t)
                {
                    this._colores[i] = null;
                    break;
                }
            }
            return i != this._cantidadMaximaColores ? i : -1;
        }

        private int Ocupados()
        {
            int i = 0;
            for ( i = 0; i < this._cantidadMaximaColores && !Object.Equals(null,this._colores[i]); i++);
            return i;
        }
        
    }
}
