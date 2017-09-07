using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    class Euro
    {
        private static double toDolarRate = 1 / 1.3642;
        private static double toPesoRate = toDolarRate * 17.55;

        private double valor;

        public Euro(double v)
        {
            this.valor = v;
        }

        
        public static Euro operator +(Euro p1, Euro p2)
        {
            return new Euro(p1.valor + p2.valor);
        }

        public static Euro operator -(Euro p1, Euro p2)
        {
            return new Euro(p1.valor - p2.valor);
        }

        #region Comparacion
        public static bool operator ==(Euro p1, Euro p2)
        {
            return p1.valor == p2.valor;
        }
        public static bool operator !=(Euro p1, Euro p2)
        {
            return !(p1.valor == p2.valor);
        }

        public static bool operator ==(Euro p, double d)
        {
            return p.valor == d;
        }
        public static bool operator !=(Euro p, double d)
        {
            return p.valor != d;
        }


        #endregion

        #region Explicit/Implicit
        public static explicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        #endregion


        public Dolar toDolar()
        {
            return new Dolar(this.valor * toDolarRate);
        }

        public Peso toPeso()
        {
            return new Peso(this.valor * toPesoRate);
        }


    }
}
