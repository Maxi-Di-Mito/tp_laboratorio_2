using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        private double Num;

        public Numero()
        {
            this.Num = 0;
        }

        public Numero(double n)
        {
            this.Num = n;
        }

        public Numero(string n)
        {
            this.SetNumero(n);
        }


        public double GetNumero()
        {
            return this.Num;
        }

        private void SetNumero(string n)
        {
            this.Num = Numero.ValidarNumero(n);
        }

        private static double ValidarNumero(string n)
        {
            double ret;
            double.TryParse(n, out ret);
            return ret;
        }

        public static Numero operator  +(Numero n1, Numero n2)
        {          
            return new Numero(n1.GetNumero() + n2.GetNumero());
        }

        public static Numero operator -(Numero n1, Numero n2)
        {
            return new Numero(n1.GetNumero() - n2.GetNumero());
        }

        public static Numero operator *(Numero n1, Numero n2)
        {
            return new Numero(n1.GetNumero() * n2.GetNumero());
        }

        public static Numero operator /(Numero n1, Numero n2)
        {
            if (n2.GetNumero() == 0)
                return new Numero(0);
            return new Numero(n1.GetNumero() / n2.GetNumero());
        }


    }
}
