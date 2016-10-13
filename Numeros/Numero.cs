using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Numero
    {
        protected int _numero;


        public int numero
        {
            get
            {
                return this._numero;
            }
        }

        public Numero(int n)
        {
            if (n < 0)
                throw new Exception("el numero debe ser positivo");
            
            this._numero = n;
        }


        public static int operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        public static int operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }

        public static int operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }

    }
}
