using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    class Peso
    {
        private static double toDolarRate = 1 / 17.55;
        private static double toEuroRate = 1 / (17.55 * 1.3642);

        private double valor;

        public Peso(double v)
        {
            this.valor = v;
        }
        public Peso(Peso p)
        {
            this.valor = p.valor;
        }

        
        public static Peso operator +(Peso p1, Peso p2)
        {
            return new Peso(p1.valor + p2.valor);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso( p + d.toPeso() );
        }

        public static Peso operator -(Peso p1, Peso p2)
        {
            return new Peso(p1.valor - p2.valor);
        }

        #region Comparacion
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.valor == p2.valor;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1.valor == p2.valor);
        }

        public static bool operator ==(Peso p, double d)
        {
            return p.valor == d;
        }
        public static bool operator !=(Peso p, double d)
        {
            return p.valor != d;
        }


        #endregion

        #region Explicit/Implicit
        public static explicit operator Peso(double d)
        {
            return new Peso(d);
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        #endregion



        public Euro toEuro()
        {
            return new Euro(this.valor * toEuroRate);
        }

        public Dolar toDolar()
        {
            return new Dolar(this.valor * toDolarRate);
        }

    }
}
