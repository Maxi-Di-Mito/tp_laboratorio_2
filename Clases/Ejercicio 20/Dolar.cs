using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    class Dolar
    {
        private static double toPesoRate = 1/17.55;
        private static double toEuroRate = 1.3642;

        private double valor;

        public Dolar(double v)
        {
            this.valor = v;
        }

        
        public static Dolar operator +(Dolar p1, Dolar p2)
        {
            return new Dolar(p1.valor + p2.valor);
        }

        public static Dolar operator -(Dolar p1, Dolar p2)
        {
            return new Dolar(p1.valor - p2.valor);
        }

        #region Comparacion
        public static bool operator ==(Dolar p1, Dolar p2)
        {
            return p1.valor == p2.valor;
        }
        public static bool operator !=(Dolar p1, Dolar p2)
        {
            return !(p1.valor == p2.valor);
        }

        public static bool operator ==(Dolar p, double d)
        {
            return p.valor == d;
        }
        public static bool operator !=(Dolar p, double d)
        {
            return p.valor != d;
        }


        #endregion

        #region Explicit/Implicit
        public static explicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        #endregion

        public Euro toEuro()
        {
            return new Euro(this.valor * toEuroRate);
        }

        public Peso toPeso()
        {
            return new Peso(this.valor * toPesoRate);
        }

    }
}
