using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace EjercicioClase5CampusProvisorio
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double n)
        {
            this.numero = n;
        }


        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            double a = nd.numero;
            double b = Conversor.BinarioDecimal((String)nb);
            double result = a + b;
            return result;
        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            double a = nd.numero;
            double b = Conversor.BinarioDecimal((String)nb);
            double result = a - b;
            return result;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nb == nd;
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return nb != nd;
        }

        public static implicit operator NumeroDecimal(double n)
        {
            return new NumeroDecimal(n);
        }

        public static explicit operator double(NumeroDecimal n)
        {
            return n.numero;
        }


    }
}
