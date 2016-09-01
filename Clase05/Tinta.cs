using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        private ETipoTinta _tipo;
        private ConsoleColor _color;

        public Tinta() 
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ETipoTinta t): this()
        {
            this._tipo = t;
        }

        public Tinta(ETipoTinta t, ConsoleColor c)
        {
            this._color = c;
            this._tipo = t;            
        }

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            return t1._tipo == t2._tipo && t1._color == t2._color;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator string(Tinta t)
        {
            return t.Mostrar();
        }

        override public string ToString()
        {
            return this.Mostrar();
        }

        override public bool Equals(Tinta t)
        {
            return this == t;
        }


        private string Mostrar()
        {
            return "Color: "+this._color.ToString() + " - TipoTinta: " + this._tipo.ToString();
        }


        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }


    }
}
