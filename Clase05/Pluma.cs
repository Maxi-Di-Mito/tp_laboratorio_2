using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "SIN MARCA";            
            this._tinta = null;
            this._cantidad = 1;

        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta)
            : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }


        private string Mostrar()
        {
            return "MARCA: " + this._marca + " - TINTA: " + this._tinta + " - CANTIDAD: " + this._cantidad;
        }


        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Pluma p, Tinta t)
        {
            return p._tinta == t;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p == t);
        }

        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p._tinta.Equals(null))
                p._tinta = t;
            else if (t == p._tinta)
                p._cantidad++;
            else
                Console.WriteLine("Las tintas son distintas");            
            return p;
        }

        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p._tinta.Equals(null))
                return p;
            else if (t == p._tinta)
            {
                p._cantidad--;
                if (p._cantidad == 0)
                    p._tinta = null;
            }
            else
                Console.WriteLine("Las tintas son distintas");
            return p;
        }

    }
}
