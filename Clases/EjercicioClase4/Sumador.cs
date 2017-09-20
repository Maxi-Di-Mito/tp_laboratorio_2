using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4
{
    class Sumador
    {
        private int cantDeSumas;

        /// <summary>
        /// Constructor
        /// </summary>
        public Sumador()
        {
            this.cantDeSumas = 0;
        }

        /// <summary>
        /// Suma dos longs en un long
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this.cantDeSumas++;
            return a + b;
        }

        /// <summary>
        /// Concatena(suma) dos strings
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {
            this.cantDeSumas++;
            return a + b;
        }

        /// <summary>
        /// Casteo de Sumador a int
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static explicit operator int(Sumador s)
        {
            return s.cantDeSumas;
        }

        /// <summary>
        /// Devuelve la suma de las dos cantidades de sumas
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long operator +(Sumador a, Sumador b)
        {
            return a.cantDeSumas + b.cantDeSumas;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Sumador a, Sumador b)
        {
            return !(a != b);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Sumador a, Sumador b)
        {
            return a.cantDeSumas == b.cantDeSumas;
        }

    }
}
